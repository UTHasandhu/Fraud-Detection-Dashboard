# Fraud-Detection-Dashboard
# Real-Time Fraud Detection Dashboard  
Streaming platform for simulating, detecting, and visualizing fraudulent financial transactions in real time.  

## Overview  
This project demonstrates a full-stack, event-driven architecture for real-time fraud detection using modern banking technologies. It simulates financial transactions, streams them through Kafka, applies ML-based anomaly detection with ML.NET, and surfaces live fraud alerts in an Angular dashboard.  

There is a producer to produce events from a dataset of credit card purchaces. This producer simulates credit card transactions happeneing worldwide.
There is are two consumers, one, a simple backend to consume and send data to the angular dashboard
The other is a producer - the ml classifier. This produces an alert for the backend to stream alerts to the dashboard as well. 

Built to showcase **event-driven microservices, streaming data pipelines, anomaly detection, and secure web application development** — all technologies heavily used in financial systems.  

Parts of the Microservice:
- **Transaction Generator** → Publishes simulated financial transactions to Kafka (`transactions`).  
- **ML.NET Service** → Consumes transactions, applies anomaly detection, publishes fraud alerts into Kafka (`alerts`).  
- **.NET Backend** → Consumes both transactions and alerts, persists them to PostgreSQL, and streams live updates to frontend via SignalR.  
- **Angular Dashboard** → Displays real-time transaction flows and alerts with filters, search, and severity indicators.  
- **PostgreSQL** → Stores historical data for querying.  
- **OAuth2/JWT** → Secures APIs and enforces role-based access control.  


## Tech Stack  

### Backend
- **.NET Core** (REST APIs, Kafka consumers, SignalR WebSocket hub)  
- **ML.NET** (anomaly detection microservice)  
- **Entity Framework Core** (PostgreSQL persistence)  
- **OAuth2/JWT** (API authentication & role-based authorization)  

### Event Streaming
- **Apache Kafka** (central messaging backbone)  

### Frontend
- **Angular** (real-time dashboard)  
- **SignalR Client** (WebSocket updates)  

### Database
- **PostgreSQL** 

## Features  
- **Simulated Transactions**: Realistic data generator to mimic financial activity.  
- **Real-Time Streaming**: Kafka-based ingestion and distribution of high-throughput events.  
- **Anomaly Detection**: ML.NET flags suspicious activity (velocity checks, location mismatches, unusual amounts).  
- **Interactive Dashboard**: Angular app for viewing live transactions and fraud alerts with filters, search, and severity-based color coding.  
- **Secure APIs**: OAuth2/JWT auth with role-based access (analyst vs. admin).  
- **Persistence**: PostgreSQL stores historical transactions and alerts.  

## 🛠️ Getting Started  

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)  
- [Node.js + Angular CLI](https://angular.io/cli)  
- [Apache Kafka](https://kafka.apache.org/quickstart)  
- [PostgreSQL](https://www.postgresql.org/download/)  
- Docker (optional, for local Kafka/Postgres setup)  

### Setup  

1. **Clone the repo**: git clone https://github.com/your-username/fraud-detection-dashboard.git -> cd fraud-detection-dashboard
2. **Start Kafka + PostgreSQL DB**: docker-compose up -d
3. **Run the .NET Backend**: cd backend dotnet run
4. **Run the ML.NET Microservice**: cd fraud-ml-service dotnet run
5. **Run the Angular Dashboard**: cd frontend npm install ng serve
6. **Access the Dashboard**: Open browser at http://localhost:4200
