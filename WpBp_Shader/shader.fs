#version 330

out vec4 FragColor;

// uniform sampler2D image;

uniform float brightness;
uniform float contrast;
varying vec2 vUv;

uniform vec4 gColor;

void main() {
  FragColor = gColor;
  // FragColor = texture2D(image, vUv);
  FragColor.rgb += brightness;

  if (contrast > 0.0) {
    FragColor.rgb = (FragColor.rgb - 0.5) / (1.0 - contrast) + 0.5;
  } else {
    FragColor.rgb = (FragColor.rgb - 0.5) * (1.0 + contrast) + 0.5;
  }
}