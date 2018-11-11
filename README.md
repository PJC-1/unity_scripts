


Unity
===================
> Learning about Video Game Development with Unity Engine

Rigidbody
-------------
To ensure that the object (*i.e. player*) will not roll, you can *lock the rotation of the player* by selecting the ```x, y, z``` check-boxes for **Freeze Rotation** under the **Constraints** section in the object's *inspector*.


Prefabs
-------------
A [prefab](https://docs.unity3d.com/Manual/Prefabs.html) is a copy of a *game object* converted into a reusable asset -- it shows up in the Project folder and is serialized as a file on disk. Prefabs can contain a hierarchy of game objects.

From the **Inspector** tab, you need to click ```Apply``` to save any changes made to the *prefab*.


Movement
-------------
To avoid giving an object a boost in movement, you can use the [```normalize```](https://docs.unity3d.com/ScriptReference/Vector3.Normalize.html) method. The *normalize* method will make the vector have a *magnitude* of ```1```.


gameObject vs Game Object
-------------
```GameObject``` is a type of object and acts as a base *class* for most Unity entities. It refers to the ```GameObject``` stored by unity which holds all *Component* data related to a ```GameObject``` (such as the ```Transform```), the name and various other things.

```gameObject``` is a local variable of type ```GameObject``` which is inherited from Component. It allows one to access the instance of the ```GameObject``` to which this component is attached.

This is explained here on [https://answers.unity.com](https://answers.unity.com/questions/32419/whats-the-difference-between-gameobject-and-gameob.html)


Audio
-------------
Generally, you will want to add *background music* to the ```Main Camera``` since it will always be in the *scene*.

*Unity* will accept the following *audio* files:
- ```ogg```
- ```wave```
- ```mp3```

You  can add *background music* by:
- using ```Add Component``` on the object.
- add an ```Audio Source``` component.
- drag your *audio-clip* into the ```AudioClip``` field.
- ensure that ```Play On Awake``` is *checked*, it will make the *audio-clip* play as soon as the *scene* loads.
- also *check* the ```Loop``` option to have audio for the whole scene.
- adjust the ```Volume``` option to your preference.

Asset Store
-------------
The [Asset Store](https://assetstore.unity.com) is where you can find:
-	Animations
-	Characters
-	Environments
-	Props
-	Audio

You can need to be logged in. When you use the "Add to My Assets" button to add any *asset* to your saved of assets. Then from Unity you can select the **Asset Store** tab and proceed to the "My Assets", where you can **Import** any of your assets into your project.


Raycasting
-------------
[Raycasting](https://unity3d.com/learn/tutorials/topics/physics/raycasting) is very important in game *3-D* game development. It allows a user to cast a line from a *gameObject* into the world. Typically it's from the *camera*, or a *gun*, or something your character is holding/aiming.
It draws a line from that object to into the world, and then we can get some information about what the object just collided with.
So when you execute ```Physics.Raycast(<STARTING POINT>, <WHAT IT HIT>, <HOW FAR>, <MASK TO MATCH>)``` the first parameter is the ```<STARTING POINT>```, which is a ```Vector3``` that is your *starting point*. That is where the *raycast* is originating from.
The second parameter will be the *out*, what you hit.
The third parameter is *how far* the cast will be.
The last parameter is the what you are trying to match, the *mask* is what you are looking for.


Nav Mesh
-------------
[Building a NavMesh](https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html)
The process of creating a **NavMesh** from the level geometry is called Terrains Baking. The process collects the Render Meshes and **Terrains** of all Game Objects which are marked as **Navigation Static**, and then processes them to create navigation *mesh* that approximates the walkable surfaces of the level.

In Unity, NavMesh generation is handled from the Navigation window (menu: ```Window > API > Navigation```).
