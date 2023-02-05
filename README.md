#1 AssignmentICG 100782088

**Platforms, Walls, End Door**

The platforms in the low-fidelity game uses a bump shader effect to give the pop to the bricks on the texture. This was done by using the in class Shader code for from the lecture 3
(Bump Mapping) and applying the texture's normal map and height map. This gave us the bumping effect but my platforms didn't look visually pleasing relative to the light source from the
bottom of the game level. To fix this I increased the slider to the max value being 10. This allowed the heightMap to show more of the vertex offset within the shader. This method was 
also used on the walls surrounding the platforms. My scene benefits from this shader beacuse of the directional and point lighting in my scene. With the main light sources coming from 
the lava, the bottom portion of the platform is well lit while the top has some lighting due to teh huge lava floor. This allows the heightMap to be used effectively as the partial light 
hitting the top platform can show the differences of vertex offset to the player clearly. 

**Skulls**

For the skulls placed on the starting and end platforms, the main shader they have is rim Lighitng. Using the code from Lecture 3, the skulls shown highlights on the edge of their
model. I changed the color and strength of the rimlighting to satisfy the red/lava environment. This was done by going on the inspector and changing the color from blue to red, 
while also lowering the slider to around 1.5 so the whole skull wouldn't be indulge in the rim color. This is important for its use showing off the Ambient, Specular, Ambient+Specular, 
and ToonRamp lighting because if the rim color was too strong, it would be harder to see the model change as its material changes. The shader code for the Ambient, Specular and Diffuse 
were used from the in class lecture 3 and Unity Scriping API, each of these shaders were placed in separated materials as it will be used for toggling each one on the skull objects.

The Specular shininess was increased in value because then it would only allow light that is shining on it to show back. Since the light was coming from the lava below, I didnt want the 
skulls in specular lighitng to have a large amonut of reflection since the light below cant reach them beacuse in between is a platform. This helps my scene look more realistic when 
specular lighting material is shown on the items relative to the lighting.

For the Toon Ramp Ligthing matieral, I used my own drawing of white to black for the shader to pick up and use when the light reflects off the object. This end results show the skull
looking golden with the behind of the skull lit very nicely from the lava lighting. This helps my scene look better as it gives me the freedom to choose the amount of lighting displayed 
on the skull based off the texture given, allowing the skulls to catch the players eyes as visually pleasing. 


Slide Deck Link:

Resources (APA7)

Font used for Win/Loss Screen
Endgame. (n.d.). Dafont.com. Retrieved February 5, 2023, from https://www.dafont.com/endgame.font?text=Victory

3D Asset Used, Skulls
(N.d.). Free3d.com. Retrieved February 5, 2023, from https://free3d.com/3d-model/skull-v3--785914.html

Lava Texture
Store, M. (2016, May 5). Lava 002. 3D TEXTURES. https://3dtextures.me/2016/05/05/lava-002/

Wall Texture
Store, M. (2022, January 4). Stone Path 007. 3D TEXTURES. https://3dtextures.me/2022/01/04/stone-path-007/

Door Texture
Store, M. (2020, January 2). Wood Door 002. 3D TEXTURES. https://3dtextures.me/2020/01/02/wood-door-002/

Platform Texture
Store, M. (2022b, May 21). Stylized Stone Floor 005. 3D TEXTURES. https://3dtextures.me/2022/05/21/stylized-stone-floor-005/

Unity API Scripting
Unity Technologies. (n.d.). Unity - scripting API: Unity3d.com. Retrieved February 5, 2023, from https://docs.unity3d.com/ScriptReference/

ICG Class Lectures 1 through 4 



