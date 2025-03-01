#version 460 core

out vec4 FragColor;
in vec4 vertexColor;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
   //FragColor = texture(ourTexture, TexCoord);
   //FragColor = texture(texture1, TexCoord);// * vertexColor;
   //vertexColor; //ourColor; //vec4(1.0f, 0.5f, 0.2f, 1.0f);   
   FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2) * vertexColor;
};