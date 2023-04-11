using IPZm.Models;
using IPZm.Students.Base;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Windows.Input;

namespace IPZm.Students.AndriiKovalets
{
    public class AndriiKovaletsViewModel : BaseStudentViewModel
    {
        public readonly static Student andriiKovaletsData = new Student(
            "Andrii",
            "Kovalets",
            "https://bit.ly/3M06b5O",
            ".NET/BackEnd developer",
            "+38 093 472 99 47",
            "andr1227",
            new List<string>
            {
                "C#", ".NET", "ASP.NET", "MSSQL", "Angular", "TypeScript"
            },
            new List<ExperienceItem>
            {
                new ExperienceItem(
                    "Admixer",
                    new DateTime(2022, 11, 9),
                    DateTime.Today,
                    "Remote"),
                new ExperienceItem(
                    "Softserve Academy",
                    new DateTime(2021, 11, 22),
                    new DateTime(2022, 02, 22),
                    "Rivne"),
            });

        public ICommand OpenLinkedInCommand { get; private set; }
        public ICommand OpenTelegramCommand { get; private set; }

        public AndriiKovaletsViewModel()
        {
            OpenLinkedInCommand = new Command(OpenLinkedIn);
            OpenTelegramCommand = new Command(OpenTelegram);
        }

        private async void OpenLinkedIn()
        {
            string linkedInUrl = "https://www.linkedin.com/in/andrii-kovalets-2b284316b/";

            await Browser.OpenAsync(new Uri(linkedInUrl));
        }

        private async void OpenTelegram()
        {
            string linkedInUrl = "https://t.me/andr1227";

            await Browser.OpenAsync(new Uri(linkedInUrl));
        }
    }
}
