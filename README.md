## This a fully functioning in memory sample Blazor application. Allows the user to register patients, add/manage doctors and appointments, bill the patients etc. 

## 🏥 Functional Modules

- **Home Landing Page**  
  Enterprise-style clinic SaaS landing page with feature overview and technology stack.

- **Patient Registration**  
  Patient demographic, insurance, and emergency contact management.

- **Doctor Management**  
  Doctor profile, specialization, consultation fee, active/inactive scheduling status.

- **Appointment Booking**  
  Active doctor filtering, scheduling conflict validation, and slot management.

- **Billing & Invoice**  
  Invoice generation, insurance coverage, patient payable calculation, and payment tracking.

- **Dashboard Analytics**  
  KPI cards for patients, doctors, appointments, bills, pending payments, and today's appointments.

## Technology stack - Blazor, C#, HTML, .NET CORE 8.0, CSS.

## Solution Architect and Developer: Vijaya Laxmi Kumbaji  Principal Software Engineer. 

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
├── wwwroot/
│   ├── app.css
│   ├── bootstrap/
│   └── favicon.png
│
├── appsettings.json
├── Program.cs
└── README.md
```



