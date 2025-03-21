 EventEaseApp

EventEaseApp is a web application designed to manage event registrations and track attendance. It includes features such as user registration with data validation, state management for user sessions, and an attendance tracker to monitor event participation.

 Features

- Registration Form: Allows users to register with their name and email, with data validation to ensure correct input.
- State Management: Tracks user sessions to ensure continuity across different pages and actions.
- Attendance Tracker: Monitors event participation and keeps track of attendees.

 Getting Started

 Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Node.js](https://nodejs.org/) (if using npm for package management)

 Installation

1. Clone the Repository:
    ```sh
    git clone https://github.com/Baffoe6/EventEaseApp.git
    cd EventEaseApp
    ```

2. Restore Dependencies:
    ```sh
    dotnet restore
    ```

3. Build the Project:
    ```sh
    dotnet build
    ```

4. Run the Application:
    ```sh
    dotnet run
    ```

5. Open the Browser:
    Navigate to `http://localhost:5288` in your web browser.

 Usage

 Registration

1. Navigate to the registration page at `http://localhost:5288/register`.
2. Enter your name and email.
3. Submit the form to register.

 Attendance Tracking

1. Use the `AttendanceService` to register attendance for events.
2. Retrieve attendance data to monitor event participation.

 Testing

 Verify Registration Form

- Ensure the form handles errors gracefully and displays validation messages for invalid input.

 Confirm State Management

- Test the `UserSessionService` to ensure it correctly tracks login and logout states.

 Check Overall App Performance

- Use browser developer tools to monitor performance and ensure the app is responsive.

 Optimization

- Follow best practices for code quality and performance.
- Remove unnecessary dependencies and optimize component rendering.

 Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

 Acknowledgements

- Thanks to the .NET community for their support and resources.
