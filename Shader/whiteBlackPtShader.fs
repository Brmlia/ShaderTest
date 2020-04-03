#version 330

out vec4 FragColor;

// uniform sampler2D image;
uniform float gBlackPoint;
uniform float gWhitePoint;
varying vec2 vUv;

uniform vec4 gColor;

void main() {
  FragColor = gColor;
  // FragColor = texture2D(image, vUv);

  float black_point = gBlackPoint / 255.0;
  float white_point = gWhitePoint == gBlackPoint ? (255.0 / 0.00025) : (255.0 / (gWhitePoint - gBlackPoint));

  FragColor.rgb = FragColor.rgb * white_point - (black_point * white_point);
}