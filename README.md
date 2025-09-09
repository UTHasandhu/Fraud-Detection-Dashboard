# Fraud-Detection-Dashboard
# Real-Time Fraud Detection Dashboard  
Streaming platform for simulating, detecting, and visualizing fraudulent financial transactions in real time.  

## Overview  
This project demonstrates a full-stack, event-driven architecture for real-time fraud detection using modern banking technologies. It simulates financial transactions, streams them through Kafka, applies ML-based anomaly detection with ML.NET, and surfaces live fraud alerts in an Angular dashboard.  

There is a producer to produce events from a dataset of credit card purchaces. This producer simulates credit card transactions happeneing worldwide.
There is are two consumers, one, a simple backend to consume and send data to the angular dashboard
The other is a producer - the ml classifier. This produces an alert for the backend to stream alerts to the dashboard as well. 

Built to showcase **event-driven microservices, streaming data pipelines, anomaly detection, and secure web application development** — all technologies heavily used in financial systems.  

