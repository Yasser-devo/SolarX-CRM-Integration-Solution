# SolarX - Dynamics 365 CRM Integration Project

This is a small-scale but expandable Dynamics 365 CRM solution designed to simulate a real-world business scenario. The project includes customizations, plugins, custom workflows, and integration with a standalone ASP.NET Core Web API.

Although it's a compact demo, it represents a solid foundation that can be scaled into a full CRM solution. It demonstrates hands-on experience with both Dynamics 365 custom development and .NET API integration, showcasing the ability to design, implement, and integrate CRM features from scratch.

---


---

## 💡 Features Implemented

### 🔷 CRM Customizations
- Custom tables/entities related to the SolarX business (e.g., Lead, Opportunity, Task)
- Structured under a custom App/Area for better organization and UI experience.
- Business Process Flow between custom entities.

### 🔷 Plugins (C#)
- Prevent duplicate Emails


### 🔷 Custom Workflows
- Example: Creat Task when opportunity created .
- Modular and reusable logic.

### 🔷 ASP.NET Core Web API
- Integration with CRM entities (e.g., Create Opportunities).
- Ready for extension with authentication and external systems.
- Built using Dependency Injection, clean architecture, and best practices.

---

## 🚀 How to Run the Project

### 1. **Import CRM Solution**
- Go to your Dynamics 365 CRM environment.
- Navigate to **Solutions** > **Import**.
- Choose the YasserCrmSolution_1_0_0_1_managed from the CRM_Solution_Files folder.
- Confirm all dependencies exist (mainly for trial environment).

### 2. **Deploy Plugin / Workflow DLLs**
- Use Plugin Registration Tool (XrmToolBox or PluginRegistration.exe).
- Register assemblies from `Plugins/` and `Workflows/` folders.
- Associate the steps/triggers manually or via solution.

### 3. **Run the Web API**
- Open the WebAPI project using Visual Studio or VS Code.
- Restore NuGet packages and build the solution.
- Update `appsettings.json` with CRM connection strings.
- Run the project using IIS Express or `dotnet run`.

---

## 📌 Notes

- This is a demo but structured with scalability in mind.
- The project reflects real-world scenarios including N:N relationships, business logic automation, and integration layers.
- Ideal for demonstration, testing, and evolving into production use.

---

## 👨‍💻 Author

Developed by a self-motivated CRM developer as a personal initiative to practice real-world Dynamics 365 scenarios and .NET integration.

---

## 📬 Contact

Feel free to connect if you're interested in discussing the solution or potential opportunities!



