using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EU4RandomCountryPicker.Interfaces;
using EU4RandomCountryPicker.Parse;
using EU4RandomCountryPicker.Structs;

namespace EU4RandomCountryPicker
{
    public partial class Form1 : Form
    {
        public List<Country> Countries { get; private set; } = new List<Country>();
        public List<string> Regions { get; private set; } = new List<string>();

        public Form1()
        {
            InitializeComponent();
            PrepareCountries();
            LoadRegions();
        }

        private void LoadRegions()
        {
            Regions.RemoveAt(0);
            RegionsListBox.Items.AddRange(
                Regions.OrderBy(x => x).ToArray());
        }

        private void PrepareCountries()
        {
            IParse iP = new HtmlTableParse();
            var convertedTable = (string)iP.Parse("https://eu4.paradoxwikis.com/Countries", "wikitable");

            AddToListCountriesFromString(convertedTable);
        }

        private void AddToListCountriesFromString(string table)
        {
            var countryInfos = table.Split(',');
            
            foreach (var countryInfo in countryInfos)
            {
                var splitedInfo = countryInfo.Split('|');
                try
                {
                    string name = splitedInfo[1];
                    string tag = splitedInfo[2];
                    string generalLocation = splitedInfo[3];
                    string exclusive = splitedInfo[4];

                    Country tempCountry = new Country(name, tag, generalLocation, exclusive);
                    Countries.Add(tempCountry);

                    CheckRegionExistOrInsert(generalLocation);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        private void CheckRegionExistOrInsert(string generalLocation)
        {
            if (!Regions.Contains(generalLocation))
                Regions.Add(generalLocation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filteredRegions = RegionsListBox.CheckedItems;
            var result = string.Empty;

            if(filteredRegions.Count > 0)
            {
                var filteredCountries = new List<Country>();

                foreach (var country in Countries.Where(c => filteredRegions.Contains(c.GeneralLocation)))
                {
                    filteredCountries.Add(country);
                }

                result = PickRandomCountry(filteredCountries);
            }
            else
            {
                result = PickRandomCountry(Countries);
            }

            PickedCountry.Text = result;
        }

        private string PickRandomCountry(List<Country> countries)
        {
            int minValue = 0;
            int maxValue = countries.Count;

            Random rnd = new Random();
            var pickedNumber = rnd.Next(minValue, maxValue);
            var pickedCountry = countries[pickedNumber];
            var result = pickedCountry.ToString();

            return result;
        }
    }
}
