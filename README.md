# 🖥️ Virtual Keyboard in C# (Windows Forms)

This project is a **Windows Forms Application** built in **C#** that simulates a fully functional keyboard.  
It allows users to interact with on-screen buttons to type into a text box, supporting special keys like **Shift**, **Caps Lock**, **Enter**, **Space**, **Backspace**, and more.

---

## 🚀 Features
- ✅ Full **QWERTY keyboard layout** with function keys (F1–F12).  
- ✅ Supports **Caps Lock** toggle with visual indicator.  
- ✅ **Shift key** for temporary uppercase and symbol typing.  
- ✅ **Backspace**, **Enter**, and **Space** work as expected.  
- ✅ **Ctrl** and **Alt** show feedback messages (extendable).  
- ✅ Interactive **UI design** using Windows Forms.  

---

## 🖼️ Preview
Here’s what the keyboard looks like:

<img width="935" height="471" alt="Screenshot 2025-09-03 163032" src="https://github.com/user-attachments/assets/d7cc602b-60f6-4c31-9c83-d74694233e16" />

---

## 📂 Project Structure
```
keyboard-design/
│
├── Form1.cs         # Main form logic and keyboard functionality
├── Form1.Designer.cs# Auto-generated form layout
├── Program.cs       # Application entry point
├── App.config       # Configuration file
└── README.md        # Project documentation
```

---

## ⚙️ How It Works
- Each key on the keyboard is represented by a **Button**.  
- The `ButtonClick` handler adds the character to the textbox.  
- **Shift** and **Caps Lock** toggle letter casing.  
- **Backspace** removes the last character.  
- **Enter** inserts a new line.  
- **Space** inserts a space character.  
- **Ctrl/Alt** currently show a message box (you can extend with shortcuts).  

---

## 🛠️ Technologies Used
- **C#**  
- **.NET Framework (Windows Forms)**  
- **Visual Studio**  

---

## 📖 Usage
1. Clone this repository:
   ```bash
   git clone https://github.com/MuhammadAL-Bothom/keyboard-design.git
   ```
2. Open the solution (`keyboard design.sln`) in **Visual Studio**.  
3. Run the project → the virtual keyboard form will appear.  
4. Click buttons to simulate typing.  

---

## 💡 Future Improvements
- Add support for **special characters** with Shift (`@, #, $, %, ^`).  
- Implement **keyboard shortcuts** with Ctrl/Alt.  
- Add **theme customization** (dark mode, colors).  
- Improve **responsive layout**.  

---

## 👨‍💻 Author
**Muhammad Al-Bothom**  
📧 [Your Email Here]  
🌐 [Your LinkedIn/GitHub Here]  

---

## 📜 License
This project is open-source. You are free to use, modify, and distribute it under the terms of the [MIT License](LICENSE).
