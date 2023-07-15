# Adapter Pattern #
The adapter design pattern is used to allow two classes with different interfaces to work together. The adapter converts the interface of a class into a targeted interface. Below you can find the items used in the Adapter design pattern:
### Target (Target): ###  
- Defines the target interface that the adapter is trying to make compatible.
### Adaptee (Class to be Adapted):###
- This is the existing class that needs to be made compatible by the adapter. The interface of this class is not compatible with the target interface.
### Adapter (Adapter): ###  
- Implements the target interface and contains the object of the class that wants to be adapted. Converts the methods of the desired class to the target interface to be adapted.
### Client (Client): ###  
- Uses Adaptee's methods via the target interface using the adapter. The client interacts through the Adapter instead of using the Adaptee directly.
The Decoupling of these items makes it possible to ensure a harmonious interaction between classes that have different interfaces. While the adapter makes an existing class compatible with the target interface, the client class performs the desired operations using the adapted class.
## The Purpose of the Code ##
- Understanding the logic of the Adapter Pattern.The 3 common ingredients found in Pizza and Pie are salt,tomato sauce, sugar, which actually make up the sauce used in these two dishes these are given in the default value. These 2 sauces are different from each other, but since the ingredients are common, it is possible to convert and use them interchangeably. In short, we will use this logic and establish the Adapter Pattern logic.
### Target  ISauce ### 
 the _sauces  field represents an array of objects derived from the ISauce interface. Therefore, the _sauces field must have a public access level in order to store instances of classes that implement the ISauce interface.
That is, the _sauces field is accessible within the Pizza class and accessible from other classes. In this way, the _sauces field can be accessed from the outside and we can assign objects that implement the ISauce interface to this field
The classes to be adapted in this example (Adaptee) are:
* Salt: The class that represents salt sauce
* TomatoSauce: The class that represents tomato sauce
* Sugar: The class that represents sugar sauce
In this example, the adapter (Adapter) classes are: 
* SaltSauceAdapter: The adapter class that adapts the salt sauce
* TomatoSauceAdapter: The adapter class that adapts tomato sauce
* SugarSauceAdapter: The adapter class that adapts the sugar sauce
* PastaSauceToPizzaAdapter: The adapter class that turns pie sauce into pizza sauce

#### Hint: ####
Adapter classes can be assigned to a variable of type ISauce because it implements the Isace interface. In this way, you can access the methods defined by the ISauce interface.
ISauce pizzaSaltSauce = new SaltSauceAdapter(pizzaSalt);

