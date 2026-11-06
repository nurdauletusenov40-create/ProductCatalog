# ProductCatalog

Қазақ тіліндегі заманауи тауарлар каталогы. Жоба университеттің зертханалық жұмысына арналып, ASP.NET Core MVC архитектурасын, нақты типтелген Razor көріністерін және Partial View тәсілін көрсетеді.

## Жобаның мақсаты

Тауарлар тізімін көрсету, тауар туралы жеке ақпарат бетіне өту, санаттарды шолу және атауы бойынша іздеу мүмкіндіктерін іске асыру. Деректер әзірге контроллердегі `List<Product>` тізімінде сақталады.

## Жобаның сипаттамасы

ProductCatalog — технологиялық тауарларға арналған шағын интернет-каталог. Негізгі бетте өнімдер, каталог статистикасы және санаттар көрсетіледі. Әр тауардың жеке беті бар. Іздеу браузерде JavaScript арқылы жедел орындалады, ал GET параметрлері бетке сілтеме арқылы өткенде іздеу мен санатты серверде өңдеуге мүмкіндік береді.

## Қолданылған технологиялар

- ASP.NET Core MVC және .NET 8
- C# және Data Annotations
- Razor (`.cshtml`) және Partial View
- HTML5, CSS3, JavaScript
- Bootstrap 5 CDN
- Visual Studio 2026 / Visual Studio Code

## Файлдық құрылымы

```text
ProductCatalog/
├── Controllers/
│   └── ProductsController.cs
├── Models/
│   └── Product.cs
├── Views/
│   ├── Products/
│   │   ├── Details.cshtml
│   │   ├── Error.cshtml
│   │   └── Index.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── _ProductCard.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   ├── css/site.css
│   ├── js/site.js
│   └── images/
├── Program.cs
├── ProductCatalog.csproj
├── ProductCatalog.sln
├── README.md
└── .gitignore
```

## Негізгі мүмкіндіктер

- Сегіз демонстрациялық тауар және теңгемен көрсетілетін бағалар.
- Каталог статистикасы: тауарлар, қолжетімді тауарлар және санаттар саны.
- Санаттар бойынша сүзгілеу және тауар атауы бойынша жедел іздеу.
- Каталог пен тауар беттеріне арналған жергілікті тауар суреттері (`wwwroot/images/`).
- `Details` бетінен тауардың толық сипаттамасын көру.
- `Views/Shared/_ProductCard.cshtml` partial көрінісі арқылы қайта қолданылатын карточкалар.
- Қазақша бейімделген, телефон мен планшетке икемді интерфейс.
- Visual Studio шешімі (`ProductCatalog.sln`) және Visual Studio Code-қа арналған жоба файлы.

## Орнату және іске қосу

Компьютерде .NET 8 SDK орнатылғанын тексеріңіз:

```powershell
dotnet --list-sdks
```

Жоба бумасында командаларды орындаңыз:

```powershell
cd ProductCatalog
dotnet restore
dotnet build
dotnet run
```

Консоль көрсеткен `http://localhost:...` мекенжайын браузерде ашыңыз. Жоба үшін дерекқор немесе Entity Framework қажет емес.

## Visual Studio 2026 арқылы ашу

1. Visual Studio Installer ішінде **ASP.NET және веб-әзірлеу** жұмыс жүктемесі орнатылғанын тексеріңіз (`.vsconfig` осы компонентті көрсетеді).
2. `ProductCatalog.sln` файлын Visual Studio арқылы ашыңыз.
3. Іске қосу профилін таңдап, **F5** немесе **Ctrl+F5** басыңыз.

Жоба .NET 8-ге бағытталған; Visual Studio 2026 ішінде де осы target framework өзгеріссіз қалады. Visual Studio Code ішінде `ProductCatalog` бумасын ашып, интеграцияланған терминалда `dotnet run` пәрменін орындауға болады.

## GitHub-қа жүктеу

GitHub-та бос репозиторий ашып, оның мекенжайын төмендегі `REPOSITORY_URL` орнына қойыңыз:

```powershell
cd ProductCatalog
git init
git add .
git commit -m "ProductCatalog MVC жобасын қосу"
git branch -M main
git remote add origin REPOSITORY_URL
git push -u origin main
```

`.gitignore` файлында құрастыру нәтижелері мен IDE-нің жеке файлдары GitHub-қа жүктелмейтіндей етіп бапталған.

## Скриншоттар

Жобаның суреттерін осы бөлімге қосыңыз. Мысалы:

```markdown
![Каталогтың басты беті](screenshots/catalog-home.png)
![Тауар туралы ақпарат](screenshots/product-details.png)
```

## Қорғауға арналған қысқаша түсіндірме

`Product` класы тауар моделін сипаттап, Data Annotations арқылы деректерді тексереді. `ProductsController` тізімдегі деректерден статистиканы есептеп, оларды `ViewBag` арқылы көрініске береді және ID бойынша тауарды табады. `Index.cshtml` нақты типтелген модель алып, әр тауарды `_ProductCard.cshtml` partial көрінісімен көрсетеді. Ортақ `_Layout.cshtml` навигация мен төменгі бөлікті барлық беттерге береді, ал JavaScript іздеу нәтижесін браузерде бірден сүзеді.
