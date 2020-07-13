# MASGlobalTest
Hans On Test solution for MAS Global Consulting

A .net solution for MAS Global Consulting as a test. 

## Getting Started
We have 2 directories API and Client, as it's names indicate is the funcioned divided from client side and backend side.
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

## Running the tests

Go to folder MASGlobalTest on API project and start debug as a New Instance. Then go to the folder MASGlobalTest.Client on Client project.
The solution should be run.

### Break down into tests

The proyect Client is a mvc.net project, it has a single Home/index view, first print a form to send "empoyeeId" and filter.
Ones the rendering view it ends, we call a Ajax function to consume the API on the backend, Ones the rendering view it ends, ones we have an answer the employed table its render.
On the backend side, the functionality is divided into the following projects:

* API: As its name implies, it provides the API that can be consumed from the client side.
* BusinessLogic: In a real project here the business logic must be carried out in this case, the repository is consumed.
* DataAccess: In this layer, the interaction with the data repositories must be carried out, be it a database or an external api. In this case we implement a factory pattern, 
which depending on the type of employee contract invokes the factory that calculates the salary.
* Entities: Includes the list of model entities and DTO's
* Tests: Must include the list of unit tests.

## Built With

* [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

* **Alvaro Arturo** - *Initial work* - [JrArturo](https://github.com/JrArturo)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Never Stop Learning
