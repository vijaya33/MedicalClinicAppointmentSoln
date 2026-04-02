This a fully functioning in memory sample Blazor application. Allows the user to register patients, add/manage doctors and appointments, bill the patients etc. 

SQL Server Database persistence functionality will be added soon.

## 📁 Project Structure

```text
MedicalClinicAppointment/
│
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   ├── NavMenu.razor
│   │
│   ├── Pages/
│   │   ├── Home.razor
│   │   ├── Dashboard.razor
│   │   ├── PatientRegistration.razor
│   │   ├── DoctorManagement.razor
│   │   ├── AppointmentBooking.razor
│   │   ├── Billing.razor
│   │   └── Error.razor
│   │
│   ├── App.razor
│   └── Routes.razor
│
├── Data/
│   └── ClinicDbContext.cs
│
├── Models/
│   ├── Patient.cs
│   ├── Doctor.cs
│   ├── Appointment.cs
│   ├── Bill.cs
│   └── DashboardSummary.cs
│
├── Services/
│   ├── IPatientService.cs
│   ├── PatientService.cs
│   ├── IDoctorService.cs
│   ├── DoctorService.cs
│   ├── IAppointmentService.cs
│   ├── AppointmentService.cs
│   ├── IBillService.cs
│   ├── BillService.cs
│   ├── IDashboardService.cs
│   └── DashboardService.cs
│
├── Migrations/
│   └── InitialCreate.cs
│
├── wwwroot/
│   ├── app.css
│   ├── bootstrap/
│   └── favicon.png
│
├── appsettings.json
├── Program.cs
└── README.md
```
