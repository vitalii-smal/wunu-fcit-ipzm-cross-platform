# IPZm Cross Platform

## Setup IDE

- [Rider](https://www.jetbrains.com/rider/download)
- [Visual Studio](https://visualstudio.microsoft.com/)

## Practical task #0

- install IDE (Rider/VS)
- compile IPZm Android project
- run application project on Android emulator/device

Help links:
- [Install Xamarin with Visual Studio on Windows](https://learn.microsoft.com/en-us/xamarin/get-started/installation/windows)
- [Set up Android emulator (Visual Studio)](https://learn.microsoft.com/en-us/xamarin/get-started/first-app/?pivots=windows-vs2022)
- [Set up Xamarin and Android emulator (Rider)](https://www.jetbrains.com/help/rider/Xamarin.html#webinar-recording-better-xamarin-development-with-rider-for-mac)

## Practical task #1

- create subdirectory with your `[FirstName][LastName]` (e.g. `VitaliiSmal`) under Students directory
- create view model [`FirstName][LastName]ViewModel` (e.g. `VitaliiSmalViewModel`) which inherits from `BaseStudentViewModel`
- create page `[FirstName][LastName]View` (e.g. `VitaliiSmalView`) which inherits from `BaseStudentContentPage` and set `BindingContext`
- add your page and Student model with your name to `_studentsPageDictionary` in `StudentsListPageViewModel`
