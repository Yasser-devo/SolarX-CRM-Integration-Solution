# SolarX - Dynamics 365 CRM Integration Project

The project includes CRM customizations, C# plugins, custom workflows, web resources, custom actions, and integration with a standalone ASP.NET Core Web API and SendGrid.

Although it's a compact demo, it represents a solid foundation that can be scaled into a full CRM solution. It demonstrates hands-on experience with Dynamics 365 custom development, .NET API integration, server-side logic, UI automation, and external service integration.

---

## 💡 Features Implemented

### 🔷 CRM Customizations
- Custom tables/entities related to the SolarX business (e.g., Lead, Opportunity, Task).
- Business Process Flow between custom entities (e.g., Lead ➝ Opportunity).
- Custom buttons on forms using JavaScript Web Resources.
- Clean UI structured under a dedicated custom app/area.

### 🔷 Plugins (C#)
- **Prevent duplicate emails**: Plugin runs on create to stop duplicate records based on email.

### 🔷 Custom Workflows (C#)
- **Auto-create Task**: When a new opportunity is created, a follow-up task is automatically generated.

### 🔷 Custom Action + SendGrid Email Integration
- Created a **Custom Action** that accepts an email address and sends an email using SendGrid.
- Built a **JavaScript Web Resource** that calls the custom action.
- Added a **button to the form** that triggers the JS function, invoking the action dynamically.
- Configured **Email Server Profile** and **Mailbox** to use SendGrid SMTP (`smtp.sendgrid.net`) for outgoing email.

### 🔷 ASP.NET Core Web API
- Integrated with CRM using OAuth2 + Azure AD App Registration.
- Example endpoint: Create Opportunity from external systems.
- Built with Clean Architecture, DI, DTOs, and follows .NET best practices.

---


## 🚀 How to Run the Project

### 1. **Import CRM Solution**
- Go to your Dynamics 365 CRM environment.
- Navigate to **Solutions** > **Import**.
- Choose the `YasserCrmSolution_1_0_0_2_managed.zip` from the CRM_Solution_Files folder.
- Confirm all dependencies exist (for sandbox/trial environments).

### 2. **Deploy Plugins / Workflows**
- Use **Plugin Registration Tool** (via XrmToolBox or `PluginRegistration.exe`).
- Register assemblies found in `Plugins/` and `Workflows/` folders.
- Link plugins to events (e.g., Create of Lead) as defined.

### 3. **Configure Email Integration (SendGrid)**
- Create a **SendGrid API Key**.
- Go to CRM → **Settings** → **Email Configuration** → **Email Server Profiles**.
- Create a new profile:
  - Outgoing Email Protocol: SMTP
  - Server: `smtp.sendgrid.net`
  - Port: `587`
  - Username: `apikey`
  - Password: [Your SendGrid API Key]
- Associate the profile with your **user's Mailbox**.
- Approve & Test Mailbox.

### 4. **Run the Web API**
- Open the WebAPI project in Visual Studio / VS Code.
- Restore NuGet packages and build the solution.
- Update `appsettings.json`:
  ```json
  "Crm": {
    "ClientId": "xxxxx",
    "ClientSecret": "xxxxx",
    "TenantId": "xxxxx",
    "Resource": "https://yourorg.crm.dynamics.com",
    "BaseUrl": "https://yourorg.api.crm.dynamics.com"
  }
## 📌 Notes


  -Demo structured for real-world extensibility.

  -Showcases CRM automation (Plugins + Workflows + Actions).
  
  -Frontend + backend + external integration all in one cohesive solution.

  -Includes real-world communication scenario (SendGrid Emailing).


---

## 👨‍💻 Author
Microsoft dynamics 365 CRM Developer

Developed by Yasser Shaheen, a CRM developer passionate about Dynamics 365 and .NET integrations. This solution reflects personal initiative and real project simulation to demonstrate cross-skill capability.


---

## 📬 Contact

Phone : +20 1027402785
Email : yassershaheen552@gmail.com
