![Build and Test](https://github.com/NalanyW/library-app/actions/workflows/dotnet.yml/badge.svg)
![Docker release and deploy](https://github.com/NalanyW/library-app/actions/workflows/docker.yml/badge.svg)

  

Inloggen.

Admin
Email: admin@admin.com
Password: Test1234,

Employee
email: employee@mail.com
password2: Test123!

User
email: user@example.com
password2: Password1!


DEVELOPMENT:

Als localhost niet werkt in chrome:
1. in een terminal: dotnet dev-certs https --clean
2. verwijder keys uit C:\Users\%username%\AppData\Roaming\ASP.NET\https
3. in een terminal: dotnet dev-certs https --trust
