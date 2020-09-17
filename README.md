# Fluent Olap Sample

This sample contains example code that uses the FluentOlap ETL system, below you will find a guide
as well.


## SW.FluentOlapSample.Models

This project will contain the models that the ETL will be widening.

The `Shipment` model is the root that will be widened.


## SW.FluentOlapSample.Bus

This project contains a very primitive listener for ShipmentMade, it showcases how to use a message
from the bus into a `PopulationContext` so that the data can be populated.


## SW.<span></span>FluentOlapSample.<span></span>Web

This project has a commented out section showing how to integrate the consumer. It is commented out,
but adding RabbitMq configuration and uncommenting will work.


## Guide

### How to use

#### Phase 1: Definition
1. Define Models
2. Add AnalyticalObject<T> definition for it.
3. Define how it handles messages using `Handles`

#### Phase 2: Population
1. Once the message is received, pass it to a `PopulationContext`.
2. Pass that context to the `PopulateAsync` method 
3. Once the data is received, it is easy to ingest it into the Database using `IngestAsync`

*Note: `IngestAsync` is available in the ingester project of fluent olap, not out on Github yet*





