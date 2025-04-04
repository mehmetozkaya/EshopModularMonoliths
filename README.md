**UDEMY COURSE WITH DISCOUNTED - Step by Step Development of this Repository -> https://www.udemy.com/course/net-backend-bootcamp-modulith-vsa-ddd-cqrs-and-outbox/?couponCode=APRI25**

See the overall picture of **Modular Monoliths (Modulith) architecture on .NET** in real-world **EShop** project;

![0modulith](https://github.com/user-attachments/assets/0f1f340e-6cb1-4bfd-aa05-f54109e5b865)

There is a couple of modules implemented **EShop** domain over **Catalog, Basket, Identity** and **Ordering** modules with **Cloud-native Backing services (Redis, RabbitMQ, Keycloak)** and **Relational PostgreSQL databases isolated db schemas**, communicating over **RabbitMQ Event Driven Communication** and following **VSA, DDD, CQRS and Outbox Patterns**.

### Check Explanation of this Repository on Medium
* [.NET Backend Bootcamp: Modular Monoliths, VSA, DDD, CQRS and Outbox](https://mehmetozkaya.medium.com/net-backend-bootcamp-modular-monoliths-vsa-ddd-cqrs-and-outbox-b6332b272209)


## Whats Including In This Repository
We have implemented below **architectural patterns in this repository**.
* Modular Monoliths (Modulith) Architecture
* Vertical Slice Architecture (VSA)
* Domain-Driven Design (DDD)
* Command Query Responsibility Segregation (CQRS)
* Outbox Pattern for Reliable Messaging

#### Catalog module which includes; 
* ASP.NET Core Minimal APIs and latest features of .NET8 and C# 12
* **Vertical Slice Architecture** implementation with Feature folders and single .cs file includes different classes in one file
* CQRS implementation using MediatR library
* CQRS Validation Pipeline Behaviors with MediatR and FluentValidation
* Use Entity Framework Core Code-First Approach and Migrations on PostgreSQL Database
* Use Carter for Minimal API endpoint definition
* Cross-cutting concerns Logging, Global Exception Handling and Health Checks

#### Basket module which includes; 
* Using Redis as a Distributed Cache over PostgreSQL database
* Implements Proxy, Decorator and Cache-aside patterns
* Publish BasketCheckoutEvent to RabbitMQ via MassTransit library
* Implement Outbox Pattern For Reliable Messaging w/ BasketCheckout Use Case

#### Module Communications; 
* Sync Communications between Catalog and Basket Modules with In-process Method Calls (Public APIs)
* Async Communications between Modules w/ RabbitMQ & MassTransit for UpdatePrice Between Catalog-Basket Modules

#### Identity module which includes; 
* OAuth2 + OpenID Connect Flows with Keycloak
* Setup Keycloak into Docker-compose file for Identity Provider as a Backing Service
* JwtBearer token for OpenID Connect with Keycloak Identity

#### Ordering module which includes; 
* Implementing DDD, CQRS, and Clean Architecture with using Best Practices
* Implement Outbox Pattern For Reliable Messaging w/ BasketCheckout Use Case

#### Migrate to Microservices; 
* EShop Modules to Microservices w/ Stranger Fig Pattern


## Run The Project
You will need the following tools:

* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 8 or later](https://dotnet.microsoft.com/download/dotnet-core/8)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)
1. Clone the repository
2. Once Docker for Windows is installed, go to the **Settings > Advanced option**, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:
* **Memory: 4 GB**
* CPU: 2
3. At the root directory of solution, select **docker-compose** and **Set a startup project**. **Run docker-compose without debugging on visual studio**.
  Or you can go to root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

4. Wait for docker compose all services. That’s it! (some microservices need extra time to work so please wait if not worked in first shut)

5. Launch **Shopping Web Api -> https://localhost:6060** in postman and send api request to internal modules. You can import postman collection in your local environment.

## Authors
* **Mehmet Ozkaya** - *Initial work* - [mehmetozkaya](https://github.com/mehmetozkaya)
