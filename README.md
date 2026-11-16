# 🌡️ TEMP MONITOR
### Temperature Sensor System
<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-purple?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge&logo=windows" />
  <img src="https://img.shields.io/badge/Framework-.NET%204.8-512BD4?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Project-Console%20Application-black?style=for-the-badge" />
</p>

### 🔵 LOW TEMPERATURE
<p align="center">



</p>

### 🟢 NORMAL TEMPERATURE
<p align="center">




</p>

### 🔴 CRITICAL TEMPERATURE
<p align="center">




</p>



---


## 📌 About The Project

**Temperature Sensor System** is a desktop application developed using C# and Windows Forms to demonstrate the **Observer Design Pattern** and the concept of **Event-Driven Programming**.

The application simulates a temperature monitoring system where a Temperature Sensor notifies multiple registered Observers whenever the temperature changes.

Using Custom Events and Delegates, the application allows different components to independently receive and respond to temperature updates without being tightly coupled to the Temperature Sensor.

## ✨ Features

- 🌡️ Display current temperature.
- 📊 Visual temperature gauge.
- ➕ Increase temperature.
- ➖ Decrease temperature.
- 🎯 Set custom temperature values.
- 🔔 Automatically notify registered Observers.
- 👀 Monitor temperature changes through multiple Observers.
- 📝 Track temperature changes in an Event Log.
- 📉 Calculate the difference between old and new temperatures.
- 🔄 Demonstrate Observer Subscription and Unsubscription.

## 🛠️ Technologies & Concepts

| **Technology** | **Usage** |
|---|---|
| C# | Main Programming Language |
| Windows Forms | Graphical User Interface |
| Delegates | Define notification method signatures |
| Events | Notify subscribed Observers |
| EventHandler<TEventArgs> | Handle temperature change notifications |
| Custom EventArgs | Pass temperature change information |
| Observer Pattern | Implement Publisher-Subscriber communication |
| Guna UI2 | Modern User Interface Components |

## 🧠 How It Works

The application follows the **Observer Design Pattern**:

1. The user changes the temperature.
2. The `TemperatureSensor` updates its current temperature.
3. The `TemperatureChanged` event is triggered.
4. All subscribed Observers receive the notification.
5. Each Observer handles the temperature update independently.
6. The UI displays the updated temperature.
7. The Event Log records the notification and temperature change.

## 🏗️ Project Architecture

```text
Temperature Sensor System
│
├── TemperatureSensor
│   ├── CurrentTemperature
│   ├── SetTemperature()
│   └── TemperatureChanged Event
│
├── TemperatureChangedEventArgs
│   ├── OldTemperature
│   ├── NewTemperature
│   └── Difference
│
├── Observers
│   ├── DisplayMonitor
│   ├── WarningSystem
│   └── Logger
│
└── Form1
    ├── Event Subscription
    ├── Event Unsubscription
    ├── Event Handlers
    ├── Temperature Display
    ├── Temperature Gauge
    └── Event History Log
```

## 📸 Screenshots

<p align="center">
  <img src="Screenshots/Dashboard.png" alt="Temperature Sensor Dashboard" width="850"/>
</p>

## 🚀 Getting Started

### Prerequisites

- Visual Studio
- C#
- Windows Forms
- Compatible .NET version
- Guna UI2 (if required by the project)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/IslamAboAlhamed/Temperature_Sensor_System.git
```

2. Open the solution file in Visual Studio.
3. Restore NuGet packages if required.
4. Build the project.
5. Run the application.

## 🎯 Learning Objectives

This project was created to practice and understand:

- Delegates in C#.
- Custom Events.
- EventHandler<TEventArgs>.
- Custom Event Arguments.
- Event Subscription and Unsubscription.
- Publisher and Subscriber concepts.
- Observer Design Pattern.
- Event-Driven Programming.
- Separation of Responsibilities.
- Loose Coupling between application components.

## 🔮 Future Improvements

- Connect a real temperature sensor.
- Add configurable temperature thresholds.
- Implement additional Observers.
- Save temperature history to a database.
- Display temperature statistics and charts.
- Add real-time temperature monitoring.

## 👨‍💻 Author

**Islam Abo Alhamed**

GitHub: [@IslamAboAlhamed](https://github.com/IslamAboAlhamed)

---

<p align="center">
  ⭐ If you find this project useful, consider giving it a star!
</p>

