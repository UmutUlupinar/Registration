# UserRegistration_microservice

REQUIREMENTS;

User Registration, Login Process, Profile Management                                                                                                                
Microservices architecture.                                                                                                                                        
employ the ELK (Elasticsearch, Logstash, Kibana) stack                                                                                                              
Command Query Responsibility Segregation (CQRS) pattern.
handle error scenarios and be prepared for service interruptions.                                                                                                   
support various error handling strategies such as error management, fault tolerance, and rollback policies                                                          
support an event-driven architecture                                                                                                                                
mock mail provider                                                                                                                                                  
                                                                                                                                                                    
TOOLS;                                                                                                                                                              
 Framework is .Net Core 7                                                                                                                                           
 ORM is EntityFrameWork for API's.                                                                                                                                  
 Databases are SQL(is for user-profil datas) and MongoDb(is for mail,log and event datas).                                                                          
 Frontend developed by MVC template.                                                                                                                                
 Git, Github and this document:) are used for CI/CD process.                                                                                                        
 Docker was used when containerizing microservices.                                                                                                                 
                                                                                                                                                                    
PROJECT STRUCTURE;                                                                                                                                                  
  BUSINESS LAYER                                                                                                                                                    
    X.API that provides user-profile actions.                                                                                                                       
      - DataAccess class library is for that includes config class for entity frameworks.                                                                           
      - Core class library that includes entities.                                                                                                                  
      - Service class library that includes logic methods.                                                                                                          
      - API is the api project that provides actions for User-Web side requests.                                                                                    
        - Middleware folder includes exception, api request serializing, authentication classes.                                                                    
                                                                                                                                                                    
  WEB LAYER                                                                                                                                                         
    X.WEB that provides UI for user-profile actions                                                                                                                 
      - Controller folder includes Home page, profil page actions.                                                                                                  
      - Models folder includes User Interface models for user-profil requests and responses.                                                                        
      - View folder includes components, templates and views for these pages  and mails.                                                                            
      - Helper folder includes classes that provide API Request, handling error, logging UX actions.                                                                
                                                                                                                                                                    
  TEST LAYER                                                                                                                                                        
    X.Test that provides testing process for projects API services.                                                                                                                                                                                                                                                                     
