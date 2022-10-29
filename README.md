# Unity-echo3D-Demo-WoodshopTraining
Train your new employees at the echo3D woodshop!

## Version
[Unity 2020.3.25f1](https://unity3d.com/get-unity/download/archive)

## Setup
* Don't have an echo3D API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Import the Unity SDK into Unity](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Ftroubleshooting%23im-getting-a-newtonsoft.json.dll-error-in-unity).

## Setup
* Clone this [repo](https://github.com/echo3Dco/Unity-echo3D-Demo-WoodshopTraining/).
* Find the 4 models of the _Axe_, _Screwdriver_, _MeasuringTape_ and _Wrench_ in the Unity folder under Assets/Models.
* [Add the assets](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the 'Models' folder.
* Open the _GarageScene_ scene in Unity.
* In the Inspector, look at the 4 objects: _AxeParent_, _ScrewdriverParent_, _MeasuringTapeParent_ and _WrenchParent_. You’ll see the echo3D SDK fields in the Inspector. <br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/195749232-466beba8-a795-4e1f-921f-29eda80bc7ce.png) <br>
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs on the echo3D script using the Inspector for all 4 objects.
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>
* (Optional) To move or edit the assets live in your project, check the boxes for “Editor Preview” and “Ignore Model Transforms”. At the top of your project, click Echo3D > Load Editor Holograms <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>

## Run
Open the WelcomeScene scene. Press Play in Unity. Follow the instructions on the screen. 
Click and hold to pick up objects, release your mouse to drop them.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Troubleshooting
Visit our troubleshooting guide [here](https://docs.echo3d.co/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).

## Screenshots
![Screenshot1](https://user-images.githubusercontent.com/99516371/198756746-9e70382f-9bfb-4e0e-81d3-77ec5cff3cbb.png)<br>
![Intro1](https://user-images.githubusercontent.com/99516371/198756773-61c64603-a06f-4b32-9038-6d5cc61cdcd8.png)<br>
![MeasuringTape](https://user-images.githubusercontent.com/99516371/198756798-e0ce9c30-5768-4261-a05c-82fb108611ad.png)<br>
![WrenchScreenshot](https://user-images.githubusercontent.com/99516371/198756824-98618448-1af1-464f-be03-6409fe8debff.png)<br>
![CongratsScreen](https://user-images.githubusercontent.com/99516371/198756833-f417ccd8-15e0-4672-9945-f57326c000e2.png)<br>




