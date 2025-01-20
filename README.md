![Build and Test](https://github.com/NalanyW/library-app/actions/workflows/dotnet.yml/badge.svg)
![Docker release and deploy](https://github.com/NalanyW/library-app/actions/workflows/docker.yml/badge.svg)

Zie [projectplan](./Devops onderbouwing project plan.pdf) voor de onderbouwing van gemaakte keuzes.


DEVELOPMENT:

Als localhost niet werkt in chrome:
1. in een terminal: dotnet dev-certs https --clean
2. verwijder keys uit C:\Users\%username%\AppData\Roaming\ASP.NET\https
3. in een terminal: dotnet dev-certs https --trust
