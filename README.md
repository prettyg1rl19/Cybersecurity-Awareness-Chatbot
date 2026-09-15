# 🤖 SentinelX — Cybersecurity Awareness Chatbot

## Interactive Cybersecurity Awareness Console Application

**SentinelX** is an interactive C# console application designed to make cybersecurity education more approachable, engaging, and conversational.

Rather than presenting cybersecurity information as a collection of static instructions, SentinelX allows users to interact with the application through natural text input while receiving spoken responses through **Speech Synthesis**.

The chatbot can identify cybersecurity-related keywords, respond to different topics, recognise basic emotional cues, remember selected user preferences, and provide conversational responses.

---

# 🌐 Project Overview

Cybersecurity awareness is an important part of protecting users from common online threats.

SentinelX was developed as an educational chatbot that introduces users to fundamental cybersecurity concepts through an interactive conversational interface.

The application focuses on topics such as:

* Password security
* Safe browsing
* Phishing
* General cybersecurity awareness
* Cybersecurity-related questions
* User emotions and conversational context

The project demonstrates how a relatively small C# console application can combine **user input, keyword recognition, conditional logic, speech synthesis, and basic conversational memory** to create an engaging user experience.

---

# ✨ Key Features

## 🔐 Cybersecurity Awareness

SentinelX provides educational responses to common cybersecurity topics.

Users can ask about:

* Passwords
* Safe browsing
* Phishing
* General cybersecurity
* Interesting cybersecurity facts

For example:

```text
User:
Tell me about passwords.

SentinelX:
[Provides a password-security response]
```

The chatbot identifies the relevant keyword and responds accordingly.

---

# 🧠 Keyword Recognition

SentinelX uses keyword detection to determine what the user is asking about.

For example:

```text
"How can I make my password safer?"
```

The chatbot can identify:

```text
password
```

and provide the corresponding cybersecurity information.

This allows users to phrase questions naturally instead of requiring an exact command.

---

# ❤️ Sentiment & Emotion Detection

One of SentinelX's distinguishing features is its ability to recognise basic emotional cues in user input.

The application can detect keywords associated with emotions such as:

* Happy
* Sad
* Uncertain
* Worried
* Confused

This allows the chatbot to respond in a more conversational manner rather than treating every interaction as a purely technical question.

For example:

```text
User:
I'm uncertain about whether this website is safe.

SentinelX:
[Provides a reassuring cybersecurity response]
```

---

# 🧠 Conversational Memory

SentinelX can remember certain information provided during a conversation.

For example, when a user indicates that they like something, the chatbot can retain that information and use it during subsequent interactions.

This provides a simple demonstration of conversational state and memory within a console application.

---

# 🔊 Speech Synthesis

SentinelX uses **Speech Synthesis** to make the application more interactive.

Instead of only displaying responses in the console, the chatbot can communicate its responses audibly.

This provides an additional layer of accessibility and makes the application feel more like an interactive assistant.

---

# 💬 Example Questions

Users can interact with SentinelX using questions or phrases such as:

```text
password
```

```text
safe browsing
```

```text
phishing
```

```text
let me ask you something
```

```text
tell me something interesting
```

The application identifies relevant keywords and responds according to the detected topic.

---

# 🖥️ User Experience

The application runs as a console application.

A typical interaction follows this pattern:

```text
┌─────────────────────────────────────────┐
│             SENTINELX 🤖                │
│                                         │
│  Hello! I'm SentinelX.                  │
│  Your cybersecurity awareness assistant.│
│                                         │
│  What would you like to know?           │
│                                         │
│  > How can I protect my passwords?      │
│                                         │
│  SentinelX:                             │
│  A strong password should be unique...  │
│                                         │
└─────────────────────────────────────────┘
```

The combination of text input and speech synthesis creates an interactive learning experience while keeping the application lightweight.

---

# 🛠️ Technologies Used

| Technology                      | Purpose                           |
| ------------------------------- | --------------------------------- |
| **C#**                          | Application development           |
| **.NET**                        | Runtime and application framework |
| **Console Application**         | User interface                    |
| **Speech Synthesis**            | Spoken chatbot responses          |
| **String / Keyword Processing** | Topic recognition                 |
| **Conditional Logic**           | Response selection                |
| **Collections / Variables**     | Conversational state              |
| **GitHub**                      | Source control                    |
| **GitHub Actions**              | Continuous Integration            |

---

# 🏗️ Project Structure

```text
Cybersecurity-Awareness-Chatbot/
│
├── .github/
│   └── workflows/
│
├── ST10438767-PROG6221-POE-Pt1/
│   └── Cybersecurity Chatbot Application
│
├── ST10438767-PROG6221-POE-Pt1.sln
│
├── Screenshot 2025-04-16 153016.png
├── Screenshot 2025-04-16 153027.png
├── Screenshot 2025-04-16 153034.png
├── Screenshot 2025-04-16 153502.png
├── Screenshot 2025-04-22 154303.png
│
├── heinzdoofenshmirtz.wav
│
└── README.md
```

The repository currently contains the main application project, solution file, screenshots, audio asset, and GitHub Actions workflow.

---

# 🚀 Getting Started

## Prerequisites

Before running SentinelX, ensure you have:

* **Visual Studio 2022 Community** or later
* A compatible **.NET SDK**
* Windows with support for the speech-synthesis functionality used by the application

---

## Clone the Repository

```bash
git clone https://github.com/prettyg1rl19/Cybersecurity-Awareness-Chatbot.git
```

Then:

```bash
cd Cybersecurity-Awareness-Chatbot
```

---

# ▶️ Running the Application

### 1. Open the project

Open the solution:

```text
ST10438767-PROG6221-POE-Pt1.sln
```

in Visual Studio.

### 2. Restore dependencies

Allow Visual Studio to restore the required project dependencies.

### 3. Run the application

Select the **Debug / Start** option in Visual Studio.

The SentinelX console application will launch.

### 4. Start interacting

Once SentinelX starts, enter a question or cybersecurity-related phrase into the console.

Try:

```text
password
```

or:

```text
tell me something interesting
```

---

# 🔄 Application Workflow

SentinelX follows a straightforward conversational workflow:

```text
                 ┌─────────────────┐
                 │  Start SentinelX│
                 └────────┬────────┘
                          │
                          ▼
                 ┌─────────────────┐
                 │  Welcome User   │
                 └────────┬────────┘
                          │
                          ▼
                 ┌─────────────────┐
                 │ Receive Input   │
                 └────────┬────────┘
                          │
                          ▼
              ┌───────────────────────┐
              │ Analyse User Message  │
              └───────────┬───────────┘
                          │
             ┌────────────┼────────────┐
             ▼            ▼            ▼
         Keyword       Emotion       Memory
         Detection     Detection     Handling
             │            │            │
             └────────────┼────────────┘
                          ▼
                 ┌─────────────────┐
                 │ Generate Reply  │
                 └────────┬────────┘
                          │
                          ▼
                 ┌─────────────────┐
                 │ Speech Synthesis│
                 └────────┬────────┘
                          │
                          ▼
                 ┌─────────────────┐
                 │ Continue Chat?  │
                 └─────────────────┘
```

---

# 🧩 Core Components

## User Input

The application receives text directly from the console.

## Keyword Detection

The input is analysed for recognised cybersecurity-related keywords.

## Response Generation

The application selects an appropriate response based on the detected topic.

## Sentiment Detection

Emotion-related keywords are identified to allow SentinelX to respond more naturally.

## Memory

Selected user preferences can be retained during the conversation.

## Speech Synthesis

Generated responses are converted into speech to provide an audible interaction.

---

# 🔄 Continuous Integration

The repository includes a **GitHub Actions workflow** for continuous integration.

This allows the project to automatically verify the application through an automated workflow whenever changes are pushed to the repository.

---

# 🎯 Learning Objectives

The project demonstrates practical application of:

* C# programming
* Object-oriented programming concepts
* Console application development
* User input handling
* String manipulation
* Keyword recognition
* Conditional logic
* Basic sentiment detection
* State management
* Speech synthesis
* Git and GitHub
* Continuous Integration

---

# 🛡️ Cybersecurity Topics

SentinelX introduces users to several fundamental cybersecurity concepts.

### Password Security

Users can learn about:

* Strong passwords
* Password uniqueness
* Password protection
* Safer authentication practices

### Phishing

The chatbot can provide information about recognising potentially malicious messages, websites, and requests for sensitive information.

### Safe Browsing

Users can learn basic practices for identifying potentially unsafe websites and improving their online browsing habits.

---

# 🌟 What Makes SentinelX Different?

SentinelX was designed to be more than a simple question-and-answer console program.

Its distinguishing features include:

### 🧠 Context Awareness

The application attempts to recognise the user's conversational context through keywords.

### ❤️ Basic Emotional Awareness

SentinelX recognises selected emotional keywords such as *happy*, *sad*, and *uncertain*.

### 💭 Memory

The chatbot can remember selected information about the user's preferences during an interaction.

### 🔊 Voice Interaction

Speech synthesis allows responses to be communicated audibly.

### 🔐 Cybersecurity Education

The entire conversational experience is centred around practical cybersecurity awareness.

---

# 📚 Project Assets

The repository contains an audio asset used as part of the chatbot experience:

```text
heinzdoofenshmirtz.wav
```

It also contains screenshots documenting the application's development and functionality.

---

# 👩‍💻 Author

**Prettyg1rl19**

Bachelor's student specialising in **Computer and Information Sciences — Application Development**.

This project demonstrates practical experience in C#, interactive application development, user-input processing, cybersecurity awareness, speech synthesis, and introductory conversational AI concepts.

---

# 📌 Project Status

**Completed**

The repository contains the completed console application, project solution, supporting assets, screenshots, and CI workflow.

---

## 🤖 SentinelX

> **Cybersecurity awareness, one conversation at a time.**
