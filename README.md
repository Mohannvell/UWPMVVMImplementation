# UWPMVVMImplementation
A simple UWP application that runs on MVVM architecture.

The Model View ViewModel (MVVM) is an architectural pattern used in software engineering that originated from Microsoft which is specialized in the Presentation Model design pattern.

MODEL: A Model is responsible for exposing data in a way that is easily consumable by UWP. It must implement INotifyPropertyChanged and/or INotifyCollectionChanged as appropriate. 

VIEW: A View is defined in XAML and should not have any logic in the code-behind. It binds to the view-model by only using data binding. 

VIEWMODEL: A ViewModel is a model for a view in the application or we can say as abstraction of the view. It exposes data relevant to the view and exposes the behaviors for the views, usually with Commands.
