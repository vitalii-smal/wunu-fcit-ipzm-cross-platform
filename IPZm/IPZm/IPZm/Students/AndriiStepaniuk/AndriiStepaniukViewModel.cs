using IPZm.Models;
using IPZm.Students.Base;
using System.Collections.Generic;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace IPZm.Students.AndriiStepaniuk
{
    public enum LinkType
    {
        LinkedIn,
        Telegram
    }
    public class AndriiStepaniukViewModel : BaseStudentViewModel
    {
        public static readonly Student studentData = new Student(
                "Andrii",
                "Stepaniuk",
                "https://bit.ly/3TR5D48",
                "SDET",
                "+380 97 649 88 69",
                "@solarisprince",
                new List<string>
                {
                    "Java", "C#", "ECMAScript", "Playwright", "Spectron", "Selenium",
                    "Jenkins", "Bitbucket Pipelines", "Postman", "Web/Desktop automated testing"
                },
                new List<ExperienceItem>
                {
                    new ExperienceItem(
                        "Forte Group, Middle SDET",
                        new DateTime(2019, 8, 15),
                        DateTime.Today,
                        "Ternopil"),
                    new ExperienceItem(
                        "Forte Group, Junior SDET",
                        new DateTime(2018, 2, 1),
                        new DateTime(2019, 8, 14),
                        "Ternopil"),
                     new ExperienceItem(
                        "Forte Group, Manual QA Engineer",
                        new DateTime(2017, 9, 1),
                        new DateTime(2018, 2, 1),
                        "Ternopil")
                });


        private string _tileBackgroundUrl = "https://bit.ly/3FZJI4S";

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

        public AndriiStepaniukViewModel()
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
                    url = "https://www.linkedin.com/in/andriy-stepaniuk/";
                    break;
                case LinkType.Telegram:
                    url = "https://t.me/solarisprince";
                    break;
                default:
                    return;
            }

            await Browser.OpenAsync(url);
        }
    }
}