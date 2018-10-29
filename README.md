


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


Asset Store
-------------
The [Asset Store](https://assetstore.unity.com) is where you can find:
-	Animations
-	Characters
-	Environments
-	Props
-	Audio

You can need to be logged in. When you use the "Add to My Assets" button to add any *asset* to your saved of assets. Then from Unity you can select the **Asset Store** tab and proceed to the "My Assets", where you can **Import** any of your assets into your project.
