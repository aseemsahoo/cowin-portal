# Cowin Portal
This project is an attempt at understanding the functioning of the Cowin web portal. It provides a similar platform for management of registration, appointment scheduling, managing 
vaccination and certification of various users. 

APIs are used to pull data from the SQL Server and, if users modify/upload existing/new data, the API makes sure the CRUD operation is invoked accordingly. For more information about APIs, please scroll down to the API section

# Table of contents
<!--ts-->
   * [Implementaion](#implementaion)
      * [Login Page](#login-page)
      * [User Dashboard Page](#user-dashboard-page)
      * [Appointment Page](#appointment-page)
        * [Step 1](#step-1)
        * [Step 2](#step-2)
   * [Application programming interface (API)](#application-programming-interface-api)
      * [Registration API](#registration-api)
      * [User Dashboard API](#user-dashboard-api)
      * [Scheduling API](#scheduling-api)
   * [Technologies & Frameworks](#technologies--frameworks)
   * [Prerequisites](#prerequisites)
   * [Installation](#installation)
   * [Roadmap](#roadmap)
   * [Acknowledgments](#acknowledgments)
<!--te-->

---

# Implementaion
### Login Page
The password has been stored in a secure way (in the database) by the use of hashing. A random salt is generated, which is unique to each password.

Currently it does not support 'Reset/Forgot Password'. It will be added soon. 

![](https://i.imgur.com/q6T5CmJ.jpg)


### User Dashboard Page
Upon successful login, the user will be either asked to register their personal details (if they haven't registered yet), or will be forwarded straight to their dashboard.

![](https://i.imgur.com/bydwPPO.jpg)

![](https://i.imgur.com/BlFLm6f.jpg)


### Appointment Page
The user is now certified for scheduling a vaccination at the required center.

- #### Step 1
He/she can search for a center across the whole country and choose from one of the three vaccines: Covishield, Covaxin and Sputnik-V.

![](https://i.imgur.com/V1Ocbu4.jpg)

- #### Step 2
This step involves selecting a date and time slot for the vaccination.

![](https://i.imgur.com/mvCZvCi.jpg)

---

# Application programming interface (API)
### Registration API
- Provide more fronts to let users login/register for vaccination

| Method   | URL                                      | Description                              |
| -------- | ---------------------------------------- | ---------------------------------------- |
| `GET`    | `/api/Cowin/Getuser/{username}`          | Retrieve user credentials                |
| `GET`    | `/api/Cowin/Getregisterstatus/{id}`      | Retrieve user register status            |
| `POST`   | `/api/Cowin/PostUser`                          | Insert a new user                        |
| `POST`   | `/api/Cowin/PostRegisteredUser`                | Insert personal details of existing user |

### User Dashboard API
- Fetch the required vaccination and personal details of the user onto the dashboard

| Method   | URL                                      | Description                              |
| -------- | ---------------------------------------- | ---------------------------------------- |
| `GET`    | `/api/Cowin/Getfulldetails/{id}`         | Retrieve user's personal details         |
| `GET`    | `/api/Cowin/Getalldoses/{id}`            | Retrieve all doses' data of the user     |

### Scheduling API
- Discover available vaccination slots and schedule or re-schedule appointments

| Method   | URL                                      | Description                              |
| -------- | ---------------------------------------- | ---------------------------------------- |
| `GET`    | `/api/Cowin/Getdistricts/{id}`           | Load all districts of given state        |
| `GET`    | `/api/Cowin/Getstates`                   | Get all the states                       |
| `POST`   | `/api/Cowin/GetCenters/{district_id}/{vaccine_id}/{age_limit}`| Retrieve all centers in a district by vaccine & age limit|
| `POST`   | `/api/Cowin/PostDoseData`                | Insert the appointment schedule data of the user |

---

# Technologies & Frameworks
This project is created with:
* Visual Studio 2022
* ASP.NET Core Web API
* SQL Server 2019

Frameworks used are:
- Dapper - a simple object mapper for .Net
- Flurl - a fluent, portable URL builder
- Newtonsoft.Json - .NET's powerful JSON serializer
- BCrypt - an easy way to keep your passwords secure
- Guna UI - an easy way to craft stunning desktop UI

---

# Prerequisites
You need the following installed on your desktop:
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [SQL Server 2019](https://www.microsoft.com/en-in/sql-server/sql-server-downloads) (optional for local connection)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (for development purposes only)

# Installation

[will be added later]

---

# Roadmap
- [x] Add Icons & Images
- [x] Add 'Reschedule Appointment'
- [x] Add Error Logging
- [x] Integrate application with Web API
- [ ] Add API key authentication
- [ ] Add 'Download Certificate'c
- [ ] Add OTP authentication

---

# Acknowledgments
* [APIs | APISetu](https://apisetu.gov.in/api/cowin#/)
* [IAmTimCorey](https://www.youtube.com/user/IAmTimCorey)
* [Stack Overflow](https://stackoverflow.com/)
* [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
* [Syncfusion Metro Studio](https://help.syncfusion.com/metro-studio/overview)
* [Flat UI Colors](https://flatuicolors.com/)
