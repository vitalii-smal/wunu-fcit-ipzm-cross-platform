using IPZm.Students.Base;
using System;
using System.Collections.Generic;
using System.Text;
using IPZm.Models;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace IPZm.Students.OleksandrKot
{
    public enum LinkType
    {
        LinkedIn,
        Telegram
    }
    public class OleksandrKotViewModel : BaseStudentViewModel
    {
        public static readonly Student studentData = new Student(
                "Oleksandr",
                "Kot",
                "https://bit.ly/3FPO9iK",
                ".NET/WPF Developer",
                "+380 97 507 78 97",
                "@o_0_000",
                new List<string>
                {
                    "C#", ".NET", "WPF",
                    ".NET Web Api", "SQL Server", "Entity Framework"
                },
                new List<ExperienceItem>
                {
                    new ExperienceItem(
                        "ELEKS",
                        new DateTime(2021, 6, 21),
                        DateTime.Today,
                        "Ternopil"),
                    new ExperienceItem(
                        "Audit Soft",
                        new DateTime(2019, 1, 31),
                        new DateTime(2019, 7, 1),
                        "Khmelnitskii"),
                });


        private string _tileBackgroundUrl = "https://bit.ly/3nfRu4d";

        public string TileBackgroundUrl
        {
            get { return _tileBackgroundUrl; }
            set { SetProperty(ref _tileBackgroundUrl, value); }
        }

        public DateTime Period
        {
            get { return new DateTime(1, 10, 11); }
        }

        public Command<LinkType?> GoToLinkCommand { get; private set; }

        public OleksandrKotViewModel()
        {
            GoToLinkCommand = new Command<LinkType?>(GoToLinkCommandExecute);
        }

        private async void GoToLinkCommandExecute(LinkType? obj)
        {
            if (obj == null)
            {
                return;
            }
            string url;
            switch (obj.Value)
            {
                case LinkType.LinkedIn:
                    url = "https://www.linkedin.com/in/oleksandr-kot-837415205/";
                    break;
                case LinkType.Telegram:
                    url = "https://t.me/o_0_000";
                    break;
                default:
                    return;
            }

            await Browser.OpenAsync(url);
        }
    }
}