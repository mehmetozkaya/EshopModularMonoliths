**UDEMY COURSE WITH DISCOUNTED - Step by Step Development of this Repository -> https://www.udemy.com/course/net-backend-bootcamp-modulith-vsa-ddd-cqrs-and-outbox/?couponCode=AUGU24**

See the overall picture of **modular monoliths on .net** on real-world **EShop** project;

![0modulith](https://github.com/user-attachments/assets/0f1f340e-6cb1-4bfd-aa05-f54109e5b865)

There is a couple of modules which implemented **e-shop** modules over **Catalog, Basket, Identity** and **Ordering** modules with **Cloud-native Backing services (Redis, RabbitMQ, Keycloak)** and **Relational PostgreSQL databases isolated db schemas** with communicating over **RabbitMQ Event Driven Communication** and following **VSA, DDD, CQRS and Outbox Patterns**.

### Check Explanation of this Repository on Medium
* [.NET Backend Bootcamp: Modular Monoliths, VSA, DDD, CQRS and Outbox](https://mehmetozkaya.medium.com/net-backend-bootcamp-modular-monoliths-vsa-ddd-cqrs-and-outbox-b6332b272209)


## Whats Including In This Repository
We have implemented below **features over the run-aspnetcore-microservices repository**.

#### Catalog microservice which includes; 
* ASP.NET Core Minimal APIs and latest features of .NET8 and C# 12
* **Vertical Slice Architecture** implementation with Feature folders and single .cs file includes different classes in one file
* CQRS implementation using MediatR library
* CQRS Validation Pipeline Behaviors with MediatR and FluentValidation
* Use Marten library for .NET Transactional Document DB on PostgreSQL
* Use Carter for Minimal API endpoint definition
* Cross-cutting concerns Logging, Global Exception Handling and Health Checks





# EshopModularMonoliths
Modular Monolithic Architecture with .NET

https://www.udemy.com/course/net-backend-bootcamp-modulith-vsa-ddd-cqrs-and-outbox/?couponCode=LAUNCHMMA

In this bootcamp, you’ll learn how to build robust, scalable, and maintainable applications using cutting-edge technologies and latest architectural patterns.

We will develop;
🔹Modular Monoliths (Modulith) Architecture
🔹Vertical Slice Architecture (VSA)
🔹Domain-Driven Design (DDD)
🔹Command Query Responsibility Segregation (CQRS)
🔹Outbox Pattern for Reliable Messaging

There is a couple of modules which implemented EShop Modular Monoliths Architecture
  those are Catalog, Basket, Identity and Ordering modules.

The data for these modules will be stored in PostgreSQL relational databases and Redis distributed cache. While we use a single PostgreSQL database, each module will have its own schema to ensure data isolation between modules.

🔹We'll follow CQRS (Command Query Responsibility Segregation) and Vertical Slice architectures for each module development.
🔹Modules will communicate over In-process method calls-public APIs and use RabbitMQ for event-driven async communication.
🔹We'll secure our APIs with Keycloak, using OpenID Connect and Bearer Tokens.
🔹We'll implement the Outbox Pattern for reliable messaging between modules.

🔹𝐂𝐚𝐭𝐚𝐥𝐨𝐠 𝗠𝗼𝗱𝘂𝗹𝗲
Using ASP.NET Core Minimal APIs
Vertical Slice Architecture implementation with Feature folders
CQRS implementation using MediatR library with Pipeline Behaviors
Use Entity Framework Core Code-First Approach and Migrations on PostgreSQL Database

🔹𝗕𝗮𝘀𝗸𝗲𝘁 𝗠𝗼𝗱𝘂𝗹𝗲
Using Redis as a Distributed Cache over PostgreSQL database
Implements Proxy, Decorator and Cache-aside patterns
Publish BasketCheckoutEvent to RabbitMQ via MassTransit library
Implement Outbox Pattern For Reliable Messaging w/ BasketCheckout Use Case

🔹𝗠𝗼𝗱𝘂𝗹𝗲 𝗖𝗼𝗺𝗺𝘂𝗻𝗶𝗰𝗮𝘁𝗶𝗼𝗻𝘀
Sync Communications between Catalog and Basket Modules with In-process Method Calls (Public APIs)
Async Communications between Modules w/ RabbitMQ & MassTransit for UpdatePrice Between Catalog-Basket Modules

🔹𝗜𝗱𝗲𝗻𝘁𝗶𝘁𝘆 𝗠𝗼𝗱𝘂𝗹𝗲 
OAuth2 + OpenID Connect Flows with Keycloak
Setup Keycloak into Docker-compose file for Identity Provider as a Backing Service
JwtBearer token for OpenID Connect with Keycloak Identity

🔹𝗢𝗿𝗱𝗲𝗿𝗶𝗻𝗴 𝗠𝗼𝗱𝘂𝗹𝗲 
Implementing DDD, CQRS, and Clean Architecture with using Best Practices 
Implement Outbox Pattern For Reliable Messaging w/ BasketCheckout Use Case

🔹𝗠𝗶𝗴𝗿𝗮𝘁𝗶𝗻𝗴 𝘁𝗼 𝗠𝗶𝗰𝗿𝗼𝘀𝗲𝗿𝘃𝗶𝗰𝗲𝘀
EShop Modules to Microservices w/ Stranger Fig Pattern
