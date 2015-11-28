using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using JeSuiSCatholic;

namespace JeSuiSCatholic
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "JeSuiSCatholic";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() {Pic="", Title="Prayers", ClassType=typeof(Prayer) },
            new Scenario() {Pic="", Title="Catholic", ClassType=typeof(Catholic) },
            new Scenario() {Pic="",Title="Confessions", ClassType=typeof(Confession) }
        };
    }

    public class Scenario
    {
        public string Title { get; set; }

        public string Pic { get; set; }

        public Type ClassType { get; set; }
    }
}
