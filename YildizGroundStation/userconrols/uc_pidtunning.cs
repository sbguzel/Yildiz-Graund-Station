using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;

namespace YildizGroundStation.userconrols
{
    public partial class uc_pidtunning : UserControl
    {
        // The data arrays that store the realtime data. The data arrays are updated in realtime. 
        // In this demo, we store at most 10000 values. 
        private const int sampleSize = 10000;
        private double[] timeStamps = new double[sampleSize];
        private double[] dataSeriesA = new double[sampleSize];
        private double[] dataSeriesB = new double[sampleSize];
        
        float current_p, current_I, current_D;
        float new_p, new_i, new_d;
        float roll_rate = 0, roll_rate_setpoint = 0, pitch_rate = 0, pitch_rate_setpoint = 0,
            yaw_rate = 0, yaw_rate_setpoint = 0, height = 0, height_setpoint = 0;

        public bool control = false;
        string trigger = "";
        
        // The index of the array position to which new data values are added.
        private int currentIndex = 0;

        // The initial full range is set to 60 seconds of data.
        private int initialFullRange = 60;

        // The maximum zoom in is 10 seconds.
        private int zoomInLimit = 10;

        // Used by the random number generator to generate real time data.
        private DateTime nextDataTime = new DateTime(DateTime.Now.Ticks / 10000000 * 10000000);

        // The first and last chart time
        DateTime firstChartTime = DateTime.MinValue;
        double chartTimeLimit;

        // The position of the track lines
        List<int> trackLinePos = new List<int>();

        // Keep track of the mouse for dragging the track lines
        int nearestTrackLine = -1;
        int nearestDistance;

        public uc_pidtunning()
        {
            InitializeComponent();
        }

        private void uc_pidtunning_Load(object sender, EventArgs e)
        {
            // Initialize the WinChartViewer
            initChartViewer(winChartViewer1);

            // Data generation rate
            dataRateTimer.Interval = 10;

            // Chart update rate
            chartUpdateTimer.Interval = 10;

            // Now can start the timers for data collection and chart update
            dataRateTimer.Start();
            chartUpdateTimer.Start();

            timer_takedata.Start();
        }

        private void timer_takedata_Tick(object sender, EventArgs e)
        {
            current_p = Form_Telemetry.current_p;
            current_I = Form_Telemetry.current_I;
            current_D = Form_Telemetry.current_D;
            roll_rate = Form_Telemetry.roll_rate;
            roll_rate_setpoint = Form_Telemetry.roll_rate_setpoint;
            pitch_rate = Form_Telemetry.pitch_rate;
            pitch_rate_setpoint = Form_Telemetry.pitch_rate_setpoint;
            yaw_rate = Form_Telemetry.yaw_rate;
            yaw_rate_setpoint = Form_Telemetry.yaw_rate_setpoint;
            height = Form_Telemetry.height;
            height_setpoint = Form_Telemetry.height_setpoint;

            lbl_currentP.Text = current_p.ToString();
            lbl_currentI.Text = current_I.ToString();
            lbl_currentD.Text = current_D.ToString();
        }

        public string getkey()
        {
            if (control == false) trigger = "";
            return trigger;
        }

        private void btn_sendnewpid_Click(object sender, EventArgs e)
        {
            new_p = Convert.ToSingle(textBox_newP.Text);
            new_i = Convert.ToSingle(textBox_newI.Text);
            new_d = Convert.ToSingle(textBox_newD.Text);
            trigger = new_p.ToString() + " " + new_i.ToString() + " " + new_d.ToString();
            control = true;
        }

        //
        // Initialize the WinChartViewer
        //
        private void initChartViewer(WinChartViewer viewer)
        {
            viewer.MouseWheelZoomRatio = 1.1;

            // Initially set the mouse usage to "Pointer" mode (Drag to Scroll mode)
            pointerPB.Checked = true;
        }

        

        //
        // The data update routine. In this demo, it is invoked every 250ms to get new data.
        //
        private void dataRateTimer_Tick(object sender, EventArgs e)
        {
            do
            {
                //
                // In this demo, we use some formulas to generate new values. In real applications,
                // it may be replaced by some data acquisition code.
                //
                double p = nextDataTime.Ticks / 10000000.0 * 4;

                double dataA = 0;
                double dataB = 0;

                if (rB_roll.Checked)
                {
                     dataA = roll_rate;
                     dataB = roll_rate_setpoint;
                }
                if (rB_pitch.Checked)
                {
                     dataA = pitch_rate;
                     dataB = pitch_rate_setpoint;
                }
                if (rB_yaw.Checked)
                {
                     dataA = yaw_rate;
                     dataB = yaw_rate_setpoint;
                }
                if (rB_height.Checked)
                {
                     dataA = height;
                     dataB = height_setpoint;
                }

                // In this demo, if the data arrays are full, the oldest 5% of data are discarded.
                if (currentIndex >= timeStamps.Length)
                {
                    currentIndex = sampleSize * 95 / 100 - 1;

                    for (int i = 0; i < currentIndex; ++i)
                    {
                        int srcIndex = i + sampleSize - currentIndex;
                        timeStamps[i] = timeStamps[srcIndex];
                        dataSeriesA[i] = dataSeriesA[srcIndex];
                        dataSeriesB[i] = dataSeriesB[srcIndex];
                    }
                }

                // Remember the first timestamps to compute the elapsed time
                if (firstChartTime == DateTime.MinValue)
                    firstChartTime = nextDataTime;

                // Store the new values in the current index position, and increment the index.
                timeStamps[currentIndex] = nextDataTime.Subtract(firstChartTime).TotalSeconds;
                dataSeriesA[currentIndex] = dataA;
                dataSeriesB[currentIndex] = dataB;
                ++currentIndex;

                nextDataTime = nextDataTime.AddMilliseconds(dataRateTimer.Interval);
            }
            while (nextDataTime < DateTime.Now);
        }

        //
        // Update the chart and the viewport periodically
        //
        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            
            WinChartViewer viewer = winChartViewer1;

            if (currentIndex > 0)
            {
                //
                // As we added more data, we may need to update the full range. 
                //

                double startDate = timeStamps[0];
                double endDate = timeStamps[currentIndex - 1];

                // Use the initialFullRange if this is sufficient.
                double duration = endDate - startDate;
                if (duration < initialFullRange)
                    endDate = startDate + initialFullRange;

                // Update the full range to reflect the actual duration of the data. In this case, 
                // if the view port is viewing the latest data, we will scroll the view port as new
                // data are added. If the view port is viewing historical data, we would keep the 
                // axis scale unchanged to keep the chart stable.
                int updateType = Chart.ScrollWithMax;
                if (viewer.ViewPortLeft + viewer.ViewPortWidth < 0.999)
                    updateType = Chart.KeepVisibleRange;
                bool axisScaleHasChanged = viewer.updateFullRangeH("x", startDate, endDate, updateType);

                // Set the zoom in limit as a ratio to the full range
                viewer.ZoomInWidthLimit = zoomInLimit / (viewer.getValueAtViewPort("x", 1) -
                    viewer.getValueAtViewPort("x", 0));

                // Trigger the viewPortChanged event to update the display if the axis scale has 
                // changed or if new data are added to the existing axis scale.
                if (axisScaleHasChanged || (duration < initialFullRange))
                    viewer.updateViewPort(true, false);

            }
        }


        //
        // Update other controls when the view port changed
        //
        private void updateControls(WinChartViewer viewer)
        {
            // Update the scroll bar to reflect the view port position and width.           
            hScrollBar1.Enabled = winChartViewer1.ViewPortWidth < 1;
            hScrollBar1.LargeChange = (int)Math.Ceiling(winChartViewer1.ViewPortWidth *
                (hScrollBar1.Maximum - hScrollBar1.Minimum));
            hScrollBar1.SmallChange = (int)Math.Ceiling(hScrollBar1.LargeChange * 0.1);
            hScrollBar1.Value = (int)Math.Round(winChartViewer1.ViewPortLeft *
                (hScrollBar1.Maximum - hScrollBar1.Minimum)) + hScrollBar1.Minimum;
        }

        //
        // Draw the chart.
        //
        private void drawChart(WinChartViewer viewer)
        {
            // Get the start date and end date that are visible on the chart.
            double viewPortStartDate = viewer.getValueAtViewPort("x", viewer.ViewPortLeft);
            double viewPortEndDate = viewer.getValueAtViewPort("x", viewer.ViewPortLeft +
                viewer.ViewPortWidth);

            // Extract the part of the data arrays that are visible.
            double[] viewPortTimeStamps = null;
            double[] viewPortDataSeriesA = null;
            double[] viewPortDataSeriesB = null;

            if (currentIndex > 0)
            {
                // Get the array indexes that corresponds to the visible start and end dates
                int startIndex = (int)Math.Floor(Chart.bSearch2(timeStamps, 0, currentIndex, viewPortStartDate));
                int endIndex = (int)Math.Ceiling(Chart.bSearch2(timeStamps, 0, currentIndex, viewPortEndDate));
                int noOfPoints = endIndex - startIndex + 1;

                // Extract the visible data
                viewPortTimeStamps = (double[])Chart.arraySlice(timeStamps, startIndex, noOfPoints);
                viewPortDataSeriesA = (double[])Chart.arraySlice(dataSeriesA, startIndex, noOfPoints);
                viewPortDataSeriesB = (double[])Chart.arraySlice(dataSeriesB, startIndex, noOfPoints);
                chartTimeLimit = timeStamps[currentIndex - 1];
            }

            //
            // At this stage, we have extracted the visible data. We can use those data to plot the chart.
            //

            //================================================================================
            // Configure overall chart appearance.
            //================================================================================

            // Create an XYChart object of size 640 x 350 pixels
            XYChart c = new XYChart(512,288);

            // Set the position, size and colors of the plot area
            c.setPlotArea(23, 33, c.getWidth() - 41, c.getHeight() - 53, c.linearGradientColor(0, 33, 0,
                c.getHeight() - 53, 0xf0f6ff, 0xa0c0ff), -1, Chart.Transparent, 0xffffff, 0xffffff);

            // As the data can lie outside the plotarea in a zoomed chart, we need enable clipping.
            c.setClipping();

            // Add a title to the chart using 18 pts Arial font
            c.addTitle("Real-Time Controller Responses", "Arial", 18);

            // Add a legend box at (60, 28) using horizontal layout. Use 8pts Arial Bold as font. Set the
            // background and border color to Transparent and use line style legend key.
            LegendBox b = c.addLegend(60, 28, false, "Arial Bold", 10);
            b.setBackground(Chart.Transparent);
            b.setLineStyleKey();

            // Set the x and y axis stems to transparent and the label font to 10pt Arial
            c.xAxis().setColors(Chart.Transparent);
            c.yAxis().setColors(Chart.Transparent);
            c.xAxis().setLabelStyle("Arial", 10);
            c.yAxis().setLabelStyle("Arial Bold", 10, 0x336699);

            // Set the y-axis tick length to 0 to disable the tick and put the labels closer to the axis.
            c.yAxis().setLabelGap(-1);
            c.yAxis().setLabelAlignment(1);
            c.yAxis().setTickLength(0);
            c.yAxis().setMargin(20);

            // Add axis title using 12pts Arial Bold Italic font
            c.yAxis().setTitle("Angular Rate", "Arial Bold", 12);

            // Configure the x-axis tick length to 1 to put the labels closer to the axis.
            c.xAxis().setTickLength(1);

            //================================================================================
            // Add data to chart
            //================================================================================

            //
            // In this example, we represent the data by lines. You may modify the code below to use other
            // representations (areas, scatter plot, etc).
            //

            // Add a line layer for the lines, using a line width of 2 pixels
            LineLayer layer = c.addLineLayer2();
            layer.setLineWidth(2);
            layer.setFastLineMode();

            // Now we add the 3 data series to a line layer, using the color red (ff0000), green (00cc00)
            // and blue (0000ff)
            layer.setXData(viewPortTimeStamps);
            layer.addDataSet(viewPortDataSeriesA, 0x00cc00, "Alpha");
            layer.addDataSet(viewPortDataSeriesB, 0x0000ff, "Beta");

            //================================================================================
            // Configure axis scale and labelling
            //================================================================================

            if (currentIndex > 0)
                c.xAxis().setDateScale(viewPortStartDate, viewPortEndDate);

            // For the automatic axis labels, set the minimum spacing to 75/30 pixels for the x/y axis.
            c.xAxis().setTickDensity(75);
            c.yAxis().setTickDensity(30);

            // We use "hh:nn:ss" as the axis label format.
            c.xAxis().setLabelFormat("{value|nn:ss}");

            // We make sure the tick increment must be at least 1 second.
            c.xAxis().setMinTickInc(1);

            //================================================================================
            // Output the chart
            //================================================================================

            // We need to update the track line too.
            trackLineLabel(c);

            // Set the chart image to the WinChartViewer
            viewer.Chart = c;
        }

        //
        // Draw track line with data labels
        //
        private void trackLineLabel(XYChart c)
        {
            // Clear the current dynamic layer and get the DrawArea object to draw on it.
            DrawArea d = c.initDynamicLayer();

            // In this example, we have two track lines.
            const int trackLineCount = 2;

            if (trackLinePos.Count == 0)
            {
                // Initialize the track line position by distributing them on the plot area
                PlotArea p = c.getPlotArea();
                for (int i = 0; i < trackLineCount; ++i)
                    trackLinePos.Add(p.getLeftX() + (int)(p.getWidth() * (i + 0.5) / trackLineCount));
            }

            // Record the positions with the track lines
            var trackLineLog = new Dictionary<string, double>[trackLineCount];

            // Draw the track lines if enabled
            if (trackLine1Enable.Checked)
                drawTrackLine(c, trackLinePos[0], trackLineLog[0] = new Dictionary<string, double>());
            if (trackLine2Enable.Checked)
                drawTrackLine(c, trackLinePos[1], trackLineLog[1] = new Dictionary<string, double>());

            // Draw the differences beteween the first two track lines
            if (trackLineCount >= 2)
                drawTrackDiff(c, trackLineLog[0], trackLineLog[1]);
        }

        void drawTrackLine(XYChart c, int lineX, Dictionary<string, double> log)
        {
            // The drawarea and plotarea objects
            DrawArea d = c.getDrawArea();
            PlotArea plotArea = c.getPlotArea();

            // Get the data x-value that is nearest to the mouse, and find its pixel coordinate.
            double xValue = c.getNearestXValue(lineX);
            int xCoor = c.getXCoor(xValue);

            // Draw empty track line if it is ahead of the data
            if ((currentIndex <= 0) || ((xCoor < lineX) && (xValue >= chartTimeLimit)))
            {
                d.vline(plotArea.getTopY(), plotArea.getBottomY(), lineX, 0x888888);
                return;
            }

            // Draw a vertical track line at the x-position
            d.vline(plotArea.getTopY(), plotArea.getBottomY(), xCoor, 0x888888);

            // Draw a label on the x-axis to show the track line position.
            string xlabel = "<*font,bgColor=000000*> " + c.xAxis().getFormattedLabel(xValue, "nn:ss.ff") +
                " <*/font*>";
            TTFText t = d.text(xlabel, "Arial Bold", 10);
            log["x"] = xValue;

            // Restrict the x-pixel position of the label to make sure it stays inside the chart image.
            int xLabelPos = Math.Max(0, Math.Min(xCoor - t.getWidth() / 2, c.getWidth() - t.getWidth()));
            t.draw(xLabelPos, plotArea.getBottomY() + 6, 0xffffff);

            // Iterate through all layers to draw the data labels
            for (int i = 0; i < c.getLayerCount(); ++i)
            {
                Layer layer = c.getLayerByZ(i);

                // The data array index of the x-value
                int xIndex = layer.getXIndexOf(xValue);

                // Iterate through all the data sets in the layer
                for (int j = 0; j < layer.getDataSetCount(); ++j)
                {
                    ChartDirector.DataSet dataSet = layer.getDataSetByZ(j);

                    // Get the color and position of the data label
                    int color = dataSet.getDataColor();
                    int yCoor = c.getYCoor(dataSet.getPosition(xIndex), dataSet.getUseYAxis());

                    // Draw a track dot with a label next to it for visible data points in the plot area
                    if ((yCoor >= plotArea.getTopY()) && (yCoor <= plotArea.getBottomY()) && (color !=
                        Chart.Transparent) && (!string.IsNullOrEmpty(dataSet.getDataName())))
                    {
                        d.circle(xCoor, yCoor, 4, 4, color, color);

                        string label = "<*font,bgColor=" + color.ToString("x") + "*> " + c.formatValue(
                            dataSet.getValue(xIndex), "{value|P4}") + " <*/font*>";
                        t = d.text(label, "Arial Bold", 10);
                        log[dataSet.getDataName()] = dataSet.getValue(xIndex);

                        // Draw the label on the right side of the dot if the mouse is on the left side the
                        // chart, and vice versa. This ensures the label will not go outside the chart image.
                        if (xCoor <= (plotArea.getLeftX() + plotArea.getRightX()) / 2)
                            t.draw(xCoor + 5, yCoor, 0xffffff, Chart.Left);
                        else
                            t.draw(xCoor - 5, yCoor, 0xffffff, Chart.Right);
                    }
                }
            }
        }

        //
        // Draw the differences between the track lines
        //
        void drawTrackDiff(XYChart c, Dictionary<string, double> log0, Dictionary<string, double> log1)
        {
            double x0, x1;
            if (!((null != log0) && log0.TryGetValue("x", out x0) && (null != log1) && log1.TryGetValue("x", out x1)))
                return;

            // Two columns in the table
            var leftCol = new System.Text.StringBuilder();
            var rightCol = new System.Text.StringBuilder();

            leftCol.Append("Change in x: ");
            rightCol.Append(c.formatValue(x1 - x0, "{value|2}"));

            // Iterate through all layers to draw the data labels
            for (int i = 0; i < c.getLayerCount(); ++i)
            {
                Layer layer = c.getLayerByZ(i);

                // Iterate through all the data sets in the layer
                for (int j = 0; j < layer.getDataSetCount(); ++j)
                {
                    var dataSetName = layer.getDataSet(j).getDataName();

                    double v0, v1;
                    if (!(log0.TryGetValue(dataSetName, out v0) && log1.TryGetValue(dataSetName, out v1)))
                        continue;
                    leftCol.Append("\nChange in ").Append(dataSetName).Append(": ");
                    rightCol.Append("\n").Append(c.formatValue(v1 - v0, "{value|2}"));
                }
            }

            string table = "<*block,bgColor=80ffffff,margin=4*><*block*>" + leftCol.ToString() +
                "<*/*><*block,halign=right*>" + rightCol.ToString() + "<*/*><*/*>";

            TTFText t = c.getDrawArea().text(table, "Arial", 10);
            t.draw(c.getPlotArea().getRightX() - t.getWidth(), c.getPlotArea().getTopY(), 0x000000);
        }

        //
        // The scroll bar event handler
        //
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            // When the view port is changed (user drags on the chart to scroll), the scroll bar will get
            // updated. When the scroll bar changes (eg. user drags on the scroll bar), the view port will
            // get updated. This creates an infinite loop. To avoid this, the scroll bar can update the 
            // view port only if the view port is not updating the scroll bar.
            if (!winChartViewer1.IsInViewPortChangedEvent)
            {
                winChartViewer1.ViewPortLeft = ((double)(hScrollBar1.Value - hScrollBar1.Minimum))
                    / (hScrollBar1.Maximum - hScrollBar1.Minimum);

                // Trigger a view port changed event to update the chart
                winChartViewer1.updateViewPort(true, false);
            }
        }

        //
        // Draw track cursor when mouse is moving over plotarea
        //
        private void winChartViewer1_MouseMovePlotArea(object sender, MouseEventArgs e)
        {
            var viewer = (WinChartViewer)sender;

            // Mouse can drag the track lines if it is in scroll mode
            var mouseUsage = viewer.MouseUsage;
            if (((mouseUsage != WinChartMouseUsage.ScrollOnDrag) && (mouseUsage != WinChartMouseUsage.Default))
                || (trackLinePos.Count == 0))
                return;

            int mouseX = viewer.ChartMouseX;

            // Check if mouse button is down
            if ((MouseButtons & MouseButtons.Left) != 0)
            {
                // If mouse is near track line, then it is dragging the track line
                if (nearestTrackLine >= 0)
                {
                    XYChart c = (XYChart)viewer.Chart;
                    PlotArea p = c.getPlotArea();

                    // move the track line while ensuring the track line is in the plot area
                    trackLinePos[nearestTrackLine] =
                        Math.Min(p.getRightX(), Math.Max(p.getLeftX(), mouseX - nearestDistance));

                    // repaint the track lines
                    trackLineLabel(c);
                    viewer.updateDisplay();
                }
            }
            else
            {
                // Check which track line is nearest to the mouse
                nearestTrackLine = -1;
                nearestDistance = 9;
                for (int i = 0; i < trackLinePos.Count; ++i)
                {
                    if (Math.Abs(mouseX - trackLinePos[i]) < Math.Abs(nearestDistance))
                    {
                        nearestTrackLine = i;
                        nearestDistance = mouseX - trackLinePos[i];
                    }
                }

                // If mouse is near the track line, it is used to drag the line, so disable drag to scroll.
                viewer.MouseUsage = ((nearestTrackLine >= 0) ? WinChartMouseUsage.Default :
                    WinChartMouseUsage.ScrollOnDrag);
            }
        }

        //
        // Pointer (Drag to Scroll) button event handler
        //
        private void pointerPB_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                winChartViewer1.MouseUsage = WinChartMouseUsage.ScrollOnDrag;
        }

        //
        // Zoom In button event handler
        //
        private void zoomInPB_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                winChartViewer1.MouseUsage = WinChartMouseUsage.ZoomIn;
        }

        //
        // Zoom Out button event handler
        //
        private void zoomOutPB_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                winChartViewer1.MouseUsage = WinChartMouseUsage.ZoomOut;
        }

        //
        // Save button event handler
        //
        private void savePB_Click(object sender, EventArgs e)
        {
            // The standard Save File dialog
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif|BMP (*.bmp)|*.bmp|" +
                "SVG (*.svg)|*.svg|PDF (*.pdf)|*.pdf";
            fileDlg.FileName = "chartdirector_demo";
            if (fileDlg.ShowDialog() != DialogResult.OK)
                return;

            // Save the chart
            if (null != winChartViewer1.Chart)
                winChartViewer1.Chart.makeChart(fileDlg.FileName);
        }

        private void trackLineEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (null != winChartViewer1.Chart)
            {
                trackLineLabel((XYChart)winChartViewer1.Chart);
                winChartViewer1.updateDisplay();
            }
        }

        //
        // The ViewPortChanged event handler. This event occurs if the user scrolls or zooms in
        // or out the chart by dragging or clicking on the chart. It can also be triggered by
        // calling WinChartViewer.updateViewPort.
        //
        private void winChartViewer1_ViewPortChanged(object sender, ChartDirector.WinViewPortEventArgs e)
        {
            // In addition to updating the chart, we may also need to update other controls that
            // changes based on the view port.
            updateControls(winChartViewer1);

            // Update the chart if necessary
            if (e.NeedUpdateChart)
                drawChart(winChartViewer1);
        }

        
    }
}
