//Encapsulation

// using Project.src.OopPrinciples.Encapsulation;

// BankAccount bankAccount = new BankAccount(100);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(50);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Withdraw(100);
// System.Console.WriteLine(bankAccount.GetBalance());


//Abstraction

// using Project.src.OopPrinciples.Abstraction;

// EmailService emailService = new EmailService();
// emailService.SendEmail();

//Inheritance

// using Project.src.OopPrinciples.Inheritance;

// var car = new Car();
// //shared
// car.Brand = "Ford";
// car.Start();
// car.Stop();

// //Unique
// car.NumberOfDoors = 4;
// car.NumberOfWheels = 4;

//Polymorphisn
//using Project.src.OopPrinciples.Inheritance;
// using Project.src.OopPrinciples.Polymorphisn;

// List<Vehicle> vehicles = new List<Vehicle>();
// vehicles.Add(new Car {Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
// vehicles.Add(new Motorcycle {Brand = "Harley Davidson", Model = "Sportster", Year = 2021});

// foreach(var vehicle in vehicles)
// {
//     vehicle.Start();
// }

//Coupling

// using Project.src.OopPrinciples.Coupling;

// var order = new Order(new SMSsender());
// order.PlaceOrder();

//Composition

// using Project.src.OopPrinciples.Composition;

// var car = new Car();
// car.StartCar();

// Composition vs Inheritance

// When you need more flexibility in constructing objects by assembling smaller, reusabte components.
// When there is no clear "is-a" relationship between classes, and a "has-a" relationship is more appropriate.
// When you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class problem - which we will look into shortly.

// When to Use Inheritance:

// When there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass.
// When you want to promote code reuse by inheriting properties and behaviors from existing classes.
// When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly through their common superclass interface.


//SOLID concept

//L
// using Project.src.SOLID.L;

// var rect = new Rectangle();
// var rect = new Square();
// rect.Height = 10;
// rect.Width = 5;
// System.Console.WriteLine("Expected are = 10 * 5 = 50");
// System.Console.WriteLine("Calculate area = " + rect.Area);

// Shape rectangle = new Rectangle{ Width = 5, Height = 4};
// System.Console.WriteLine($"Area of Rectangle: {rectangle.Area}" );

// Shape square = new Square {SideLenght = 5};
// System.Console.WriteLine($"Area of Square: {square.Area}" );

// I

// using Project.src.SOLID.I;

// var circle = new Circle();
// circle.Radius = 10;
// System.Console.WriteLine(circle.Area());

// D
// using Project.src.SOLID.D;

// var car = new Car(new Engine());


//Memnto

// using Project.src.DesignPatterns.Behavioral.Memento;

// var editor = new Editor();
// var history = new History(editor);
// history.Backup();
// editor.Title = "Test";
// history.Backup();
// editor.Content = "hello there";
// history.Backup();
// editor.Title = "test 2";

// System.Console.WriteLine("Title: " + editor.Title);
// System.Console.WriteLine("Content: " + editor.Content );

// history.Undo();
// System.Console.WriteLine("Title: " + editor.Title);
// System.Console.WriteLine("Content: " + editor.Content );

// history.ShowHistory();

// history.Undo();
// System.Console.WriteLine("Title: " + editor.Title);
// System.Console.WriteLine("Content: " + editor.Content );

// using Project.src.DesignPatterns.Behavioral.State;

// var doc = new Document();
// doc.State = DocumentState.Moderation;
// doc.CurrentUserRole = UserRoles.Editor;

// System.Console.WriteLine(doc.State);

// doc.Publish();
// System.Console.WriteLine(doc.State);

// using Project.src.DesignPatterns.Behavioral.State.GoodSolution;

// var doc = new Document(UserRoles.ADMIN);
// System.Console.WriteLine(doc.State);

// doc.Publish();
// System.Console.WriteLine(doc.State);

// doc.Publish();
// System.Console.WriteLine(doc.State);

// doc.State = new DraftState(doc);
// System.Console.WriteLine(doc.State);

// Strategy
// using Project.src.DesignPatterns.Behavioral.Strategy.GoodExample;

// var videoStorge = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
// videoStorge.Store("/videos/some-movie");

// videoStorge.SetCompressor(new CompressorMP4());
// videoStorge.SetOverlay( new OverlayNone());
// videoStorge.Store("/videos/some-movie");


// Difference between Strategy and State:

// The two patterns are similar in practice, and the difference between them varies depending on who you 
// ask. Some popular choices are:

// - States store a reference to the context object that contains them. Strategies do not.|
// - States are allowed to replace themselves (IE: to change the state of the context object to
// something else), while Strategies are not.
// - Strategies ont handle a single, specific task, while States provide the underlying implementation
// for everything (or most everything) the context object does.

/*
When to use
A good rule of thumb for when it might be a good time to reach for the Strategy Pattern is when
you have a class with a large number of conditional statements that switch between variants of the same algorithm. The algorithm logic can be extracted into separate classes that implement
the same interface. The context object then delegates the work to these classes, instead of implementing all the algorithms itself.

Pros and cons
+ Satisfies open/closed principle: can add new strategies without modifying the context.
+ Can swap algorithms used inside an object at runtime.

- Clients have to be aware of the different algorithms and select the appropriate one.
- If you only have a few algorithms that rarely change, then using the Strategy Pattern may be over-engineering.
*/

//Iterator
// using Project.src.DesignPatterns.Behavioral.Iterator.GoodExample;

// ShoppingList list = new ShoppingList();
// list.Push("Milk");
// list.Push("Bread");
// list.Push("Steak");

// for(int i = 0; i < list.GetList().Count; i++){
//     var item = list.GetList()[i];
//     System.Console.WriteLine(item);

// }

// var iterator = list.CreateIterator();
// while(iterator.HasNext()){
//     System.Console.WriteLine(iterator.Current());
//     iterator.Next();
// }

//Command

// using Project.src.DesignPatterns.Behavioral.Command;

// var light = new Light();
// var remoteControl = new RemoteControl(light);
// remoteControl.PressButton(true);
// remoteControl.PressButton(false);

// using Project.src.DesignPatterns.Behavioral.Command.GoodLight;

// var light = new Light();
// var remote = new RemoteControl(new TurnONCommand(light));
// remote.PressButton();

// remote.SetCommand(new DimCommand(light));
// remote.PressButton();

// using Project.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern;

// var htmlDoc = new HtmlDocument();
// var history = new History();
// htmlDoc.Content = "Hello World";
// System.Console.WriteLine(htmlDoc.Content);

// var italicCommand = new ItalicCommand(htmlDoc, history);
// italicCommand.Execute();
// System.Console.WriteLine(htmlDoc.Content);

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// System.Console.WriteLine(htmlDoc.Content);


//Template Bad Example
// using Project.src.DesignPatterns.Behavioral.Template.BadExample;

// var tea = new Tea();
// tea.MakeBeverage();

// var coffee = new Coffee();
// coffee.MakeBeverage();

// Template Polymorphism Example
// using Project.src.DesignPatterns.Behavioral.Template.PolymorphismExample;

// var beverageMaker = new BeverageMaker(new Tea());
// beverageMaker.MakeBeverage();

// beverageMaker.SetBeverage(new Coffee());
// beverageMaker.MakeBeverage();


// Template Inheritance Example
// using Project.src.DesignPatterns.Behavioral.Template.InheritanceExample;

// var tea = new Tea();
// tea.Prepare();

// var camomile = new Camomile();
// camomile.Prepare();

// Template Method vs Strategy Pattern

// Template Method Pattern:
//     . Use the Template Method Pattern when you have an algorithm with a fixed structure but
//     with certain steps that need to be customized or implemented differently by subclasses.
//     · This pattern is ideal when you want to define a common algorithm skeleton (templatemethod) in a base class and allow subclasses to selectively override specific steps to provide their own implementations.
//     · The Template Method Pattern is suitable when the overall algorithm structure remains
//     consistent, but specific parts of the algorithm can vary based od different requirements
//     or contexts.

// Strategy Pattern:
//     . Use the Strategy Pattern when you want to define a family of interchangeable algorithms
//     or behaviors and encapsulate each algorithm into its own class.

//     · This pattern is ideal when you need to dynamically select and switch between different
//     algorithms at runtime, depending on the situation or context.
//     . The Strategy Pattern is suitable when you want to decouple the client code from specific
//     algorithm implementations, allowing greater flexibility and extensibility.

// Observer
// Bad Example
// using Project.src.DesignPatterns.Behavioral.Observer.BadExample;

// DataSource dataSource = new DataSource();

// Sheet2 sheet2 = new Sheet2();
// BarChart barChart = new BarChart();

// dataSource.AddDependent(sheet2);
// dataSource.AddDependent(barChart);

// dataSource.SetValues([5, 5, 1, 10]);
// dataSource.SetValues([1, 2, 3]);

// Good Example
// using Project.src.DesignPatterns.Behavioral.Observer.GoodExample;

// DataSource dataSource = new DataSource();

// Sheet2 sheet2 = new Sheet2(dataSource);
// BarChart barchart = new BarChart(dataSource);

// dataSource.AddObserver(sheet2);
// dataSource.AddObserver(barchart);

// dataSource.SetValues([5, 5, 1, 10]);
// dataSource.SetValues([1, 2, 3]);

// Mediator
// Good Example
// using Project.src.DesignPatterns.Behavioral.Mediator.GoodExample;

// var postDialogBox = new PostsDialogBox();
// postDialogBox.SimulateUserInteraction();

// using Project.src.DesignPatterns.Behavioral.Mediator.WithObserver;

// var postsDialogBox = new PostsDialogBox();
// postsDialogBox.SimulateUserInteraction();

// Chain Of Responsibility

// using Project.src.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample;

// var server = new WebServer();
// var request = new HttpRequest("danny", "123");
// server.Handle(request);

// using Project.src.DesignPatterns.Behavioral.ChainOfResponsibility.GoodExample;

// var validator = new Validator();
// var authenticator = new Authenticator();
// var logger = new Logger();
// validator.SetNext(authenticator).SetNext(logger);

// var server = new WebServer(validator);
// var req = new HttpRequest("danny", "123");
// server.Handle(req);

// var req2 = new HttpRequest("danny", "1234");
// server.Handle(req2);

// var req3 = new HttpRequest("", "");
// server.Handle(req3);

// Visitor
// using Project.src.DesignPatterns.Behavioral.Visitor.BadExample;

// var clients = new List<Client>{
//     new Retail("Debinhams", "team@debinhams.co.uk"),
//     new Restaurant("Frankie and Bennys", "frank@fandb.com"),
//     new Law("Hamlin McGil Law Firm", "howard@handm.com")
// };
// foreach(var client in clients){
//     client.SendEmail();
// }

// using Project.src.DesignPatterns.Behavioral.Visitor.GoodExample;

// var clients = new List<Client>{
//     new Retail("Debinhams", "team@debinhams.co.uk"),
//     new Restaurant("Frankie and Bennys", "frank@fandb.com"),
//     new Law("Hamlin McGil Law Firm", "howard@handm.com")
// };
// foreach(var client in clients){
//     client.Accept(new EmailVisitor());
//     client.Accept(new PDFExportVisitor());
// }

// Interpreter
// using Project.src.DesignPatterns.Behavioral.Interpreter;

// string input = "2 + 3 - 4 + 10";
// Context context = new Context();
// Interpreter2 interpreter = new Interpreter2(context);
// int result = interpreter.Interpret(input);
// System.Console.WriteLine("Result: " + result);

/* Structural Desing Patter*/
//Composite
// using Project.src.DesignPatterns.Structural.Composite.GoodExample;

// var package = new Box();

// var box1 = new Box();
// box1.Add(new Microphone());

// var box2 = new Box();

// var box3 = new Box();
// box3.Add(new Mouse());

// var box4 = new Box();
// box4.Add(new Keyboard());

// box2.Add(box3);
// box2.Add(box4);

// package.Add(box1);
// package.Add(box2);

// System.Console.WriteLine("Total prive of package = " + package.GetPrice());

//Bridge
// Bad Example
// using Project.src.DesignPatterns.Structural.Bridge.BadExample;

// var lgRermote = new LGRemote();
// lgRermote.TurnOn();
// lgRermote.TurnOff();

// var lgRadioAndTVLGRemote = new LGRadioAndTVLGRemote();
// lgRadioAndTVLGRemote.ControlTV();
// lgRadioAndTVLGRemote.TurnOn();
// lgRadioAndTVLGRemote.VolumeUp();

// Good Example
// using Project.src.DesignPatterns.Structural.Bridge.GoodExample;

// var lgRemoteControl = new RemoteControl(new LGRadio());
// lgRemoteControl.TurnOn();
// lgRemoteControl.TurnOff();

// var SonyRemoteControl = new RemoteControl(new SonyRadio());
// SonyRemoteControl.TurnOn();
// SonyRemoteControl.TurnOff();

// var advancedSonyControl = new AdvancedRemote(new SonyRadio());
// advancedSonyControl.TurnOn();
// advancedSonyControl.SetChannel(2);

// Proxy
// using Project.src.DesignPatterns.Structural.Proxy.GoodExample;

// var videolist = new VideoList();
// String[] videoids = {"1234", "abcde", "sdobheriogve"};

// foreach(var videoid in videoids){
//     videolist.Add(new YouTubeVideoProxy(videoid));
// }

// videolist.Watch("abcde");

// Proxy
// Bad Example
// using Project.src.DesignPatterns.Structural.Flyweight.BadExample;

// var cropService = new CropService();

// foreach(var crop in cropService.GetCrops()){
//     crop.Render();
// }

// Good Example
// using Project.src.DesignPatterns.Structural.Flyweight.GoodExample;

// var cropService =  new CropService(new CropIconFactory());

// foreach(var crop in cropService.GetCrops()){
//     crop.Render();
// }

// Facade
// Bad Example
// using Project.src.DesignPatterns.Structural.Facade.BadExample;

// var orderReq = new OrderRequest();
// var auth = new Authenticate();
// var inventory = new Inventory();

// foreach(var id in orderReq.ItemIds){
//     inventory.CheckInventory(id);
// }
// var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
// payment.Pay();
// var orderfullfillment = new OrderFulfillment(inventory);
// orderfullfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);

// Good Example
// using Project.src.DesignPatterns.Structural.Facade.GoodExample;

// var orderReq = new OrderRequest();
// var orderService = new OrderService();
// orderService.Order(orderReq);

// Decrator
// Bad Example
// using Project.src.DesignPatterns.Structural.Decorator.BadExample;
// User input data
// var url = "https://google.cloud.com";
// var data = "This is some data. Hello world. Facade Facade";
// var compress = true;
// var encrypt = true;

// var cloudData = new CloudData(url);
// if(compress && encrypt){
//     cloudData = new CompressedAndEncryptedData(url);
// }
// else if(compress){
//     cloudData = new CompressedData(url);
// }
// else if(encrypt){
//     cloudData = new EncryptedData(url);
// }

// cloudData.Save(data);

// Good Example
// User input data
// using Project.src.DesignPatterns.Structural.Decorator.GoodExample;

// var url = "https://google.cloud.com";
// var data = "This is some data. Hello world. Facade Facade";
// var compress = false;
// var encrypt = false;

// Data cloudData = new CloudData(url);
// if(encrypt)
// {
//     cloudData = new EncryptionDecorator(cloudData);
// }
// if(compress)
// {
//     cloudData = new CompressionDecorator(cloudData);
// }

// cloudData.Save(data);


// Creational Desing Pattern 
// Prototype
// Bad Example
// using Project.src.DesignPatterns.Creational.Prototype.BadExample;

// var circle = new Circle();
// circle.Draw();

//user clikc and drags to resize
// circle.Radius = 12;

// user adds a new rectangel to GUI
// var rectangle = new Rectangle();
// rectangle.Draw();

//user clikc and fega rectangle to resize
// rectangle.Width = 20;
// rectangle.Height = 12;

// user right-clicking and selecting "duplicate"
// var shapeAction = new ShapeActions();
// shapeAction.Duplicate(circle);
// shapeAction.Duplicate(rectangle);

// Good Example
// using Project.src.DesignPatterns.Creational.Prototype.GoodExample;

// var circle = new Circle();
// circle.Draw();

// user clikc and drags to resize
// circle.Radius = 12;

// user adds a new rectangel to GUI
// var rectangle = new Rectangle();
// rectangle.Draw();

// user clikc and fega rectangle to resize
// rectangle.Width = 20;
// rectangle.Height = 12;

// user right-clicking and selecting "duplicate"
// var shapeAction = new ShapeActions();
// Shape newCircle = shapeAction.Duplicate(circle);
// newCircle.Draw();
// Shape newRectangle = shapeAction.Duplicate(rectangle);
// newRectangle.Draw();

// Singleton
// using Project.src.DesignPatterns.Creational.Singleton.BadExample;

// var settings = new AppSettings();
// settings.Set("app_name", "Desing Patterns Meastery");
// settings.Set("app_creator", "Danny");
// System.Console.WriteLine(settings.Get("app_name"));

// Good Example
// using Project.src.DesignPatterns.Creational.Singleton.GoodExample;

// var settings = AppSettings.GetInstance();
// settings.Set("app_name", "Desing Patterns Meastery");
// settings.Set("app_creator", "Danny");
// System.Console.WriteLine(settings.Get("app_name"));

// Abstract Factory 
// Bad Example
// using Project.src.DesignPatterns.Creational.AbstractFactory.BadExample;
// using Project.src.DesignPatterns.Creational.AbstractFactory.BadExample.App;

// var os = OperatingSystemType.Windows;
// var userSettingsForm = new UserSettingsForm();
// userSettingsForm.Render(os);

// Good Example
// using Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample;
// using Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample.App;
// using Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac;
// using Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample.Windows;

// var os = OperatingSystemType.Mac;
// IUIComponentFactory uIComponentFactory;
// if (os == OperatingSystemType.Windows){
//     uIComponentFactory = new WindowsUIComponentFactory();
// }
// else if (os == OperatingSystemType.Mac){
//     uIComponentFactory = new MacUIComponentFactory();
// }
// else{
//     throw new Exception("Unsupported operating system");
// }
// new UserSettingsForm().Render(uIComponentFactory);

// Builder
// Bad Example
// using Project.src.DesignPatterns.Creational.Builder.BadExample;
// using Project.src.DesignPatterns.Creational.Builder.BadExample.Components;

// var sportcar = new Car(Project.src.DesignPatterns.Creational.Builder.BadExample.Components.CarType.Sports, 
//                         seats: 2, isConvertible: false, 
//                         new Project.src.DesignPatterns.Creational.Builder.BadExample.Components.Engine(), 
//                         new Dashboard(hasRevCounter: true), 
//                         new Wheels(diameterInInches: 20), 
//                         new GPSNavigator()
//                     ); 
// sportcar.Fuel = 100;

// var suvCar = new Car(CarType.SUV, 
//                     seats: 5, isConvertible: false, 
//                     new Engine(), 
//                     new Dashboard(hasRevCounter: true), 
//                     new Wheels(diameterInInches: 19), 
//                     new GPSNavigator()
//                 );
// suvCar.Fuel = 40;

// var sportcarmanual = new Manual(CarType.Sports, 
//                         seats: 2, isConvertible: false, 
//                         new Engine(), 
//                         new Dashboard(hasRevCounter: true), 
//                         new Wheels(diameterInInches: 20), 
//                         new GPSNavigator()
//                     ); 
// System.Console.WriteLine(sportcarmanual.Print());

// var suvCarmanual = new Manual(CarType.SUV, 
//                     seats: 5, isConvertible: false, 
//                     new Engine(), 
//                     new Dashboard(hasRevCounter: true), 
//                     new Wheels(diameterInInches: 19), 
//                     new GPSNavigator()
//                 );
// System.Console.WriteLine(suvCarmanual.Print());

// Good Example
// using Project.src.DesignPatterns.Creational.Builder.GoodExample;
// using Project.src.DesignPatterns.Creational.Builder.GoodExample.Components;

// var carBuilder = new CarBuilder();
// carBuilder.SetCarType(CarType.Sports)
//             .SetSeats(5)
//             .SetEngine(new Engine())
//             .SetDashboard(new Dashboard(hasRevCounter: true))
//             .SetWheels(new Wheels(diameterInInches:20));
// var sportsCar = carBuilder.GetCar();
// sportsCar.Fuel = 100;

// var manualBuilder = new CarManualBuilder();
// manualBuilder.SetCarType(CarType.Sports)
//             .SetSeats(seats: 2)
//             .SetEngine(new Engine())
//             .SetDashboard(new Dashboard(hasRevCounter: true))
//             .SetWheels(new Wheels(diameterInInches: 20));  
// var sportsCarManual = manualBuilder.GetManual();
// System.Console.WriteLine(sportsCarManual.Print());

// var carBuilder = new CarBuilder();
// var director = new Director();
// director.ConstructSportsCar(carBuilder);
// var sportsCar = carBuilder.GetCar();
// sportsCar.Fuel = 100;

// director.ConstructSUV(carBuilder);
// var suvCar = carBuilder.GetCar();
// suvCar.Fuel = 40;

// var manulaBuilder = new CarManualBuilder();
// director.ConstructSportsCar(manulaBuilder);
// var sportsCarManual = manulaBuilder.GetManual();
// System.Console.WriteLine(sportsCarManual.Print());

// director.ConstructSUV(manulaBuilder);
// var suvmanual = manulaBuilder.GetManual();
// System.Console.WriteLine(suvmanual.Print());
