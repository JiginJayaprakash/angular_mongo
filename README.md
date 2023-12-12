# angular_mongo

To run the application in codespaces, click on Code and select Codespaces tab and "Create a codespace on main"

## To run the project

Once the codespace has started, open a terminal and follow the steps

```
cd api/webapiproj

dotnet build

dotnet run
```

Once the application is running , go to port tab beside terminal and make port 5134 public by right clicking on it > Port Visibility > Public

Also copy the address by right clicking on the port 5134 and Copy Local Address 

This value should be pasted in ClientApp/src/environments/environment.ts replace the value for the key - baseUrl

Make sure you let port 5134 running and is showing green circle right side of the port number in PORTS tab

Once the port is made public , open a new terminal by clicking on the three line icon on the top left corner > Terminal > New Terminal

then follow these steps

```
cd ClientApp

npm install

npm start
```


For running the test case, open a new terminal as mentioned above then follow these steps

```
cd api

dotnet test
```
you can update or add values in api>Binary.Tests>UnitTes.cs and run dotnet test to see the updated results

