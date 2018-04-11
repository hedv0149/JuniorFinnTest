using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuniorFINNApp
{
	public partial class MainPage : ContentPage
	{
        Ads ads = new Ads();
        List<Label> labelList = new List<Label>();
        Grid GridForPuttingDataIntoTwoColumns;
        int countOfRows = 0;
        public MainPage()
		{
			InitializeComponent();
            ads.ConvertJSONDataIntoAds();
            GridForPuttingDataIntoTwoColumns = this.FindByName<Grid>("GridForPuttingDataIntoTwoColumnss");
            PopulateList();

            for (int i = 0; i < labelList.Count; i=+2)
            {
                
                GridForPuttingDataIntoTwoColumns.Children.Add(labelList[i], countOfRows /*col*/, 0 /*row*/);
                GridForPuttingDataIntoTwoColumns.Children.Add(labelList[i++], countOfRows, 1);
                countOfRows++;
            }

        }

        private void PopulateList()
        {
            var topLeft = new Label { Text = "Top Left" };
               var topRight = new Label { Text = "Top Right" };
              //var bottomLeft = new Label { Text = "Bottom Left" };
                //var bottomRight = new Label { Text = "Bottom Right" };

            labelList.Add(topLeft);
               labelList.Add(topRight);
               //labelList.Add(bottomLeft);
                //labelList.Add(bottomRight);
        }
    }
}
