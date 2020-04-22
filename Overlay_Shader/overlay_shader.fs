#version 330

out vec4 FragColor;

uniform vec4 gColor;
uniform vec4 gOverlay;

vec4 toGrayscale(in vec4 color) {
  float average = (color.r + color.g + color.b) / 3.0;
  return vec4(average, average, average, 1.0);
}

vec4 colorize(in vec4 grayscale, in vec4 color)
{
    return (grayscale * color);
}

void main() {;
  vec4 grayscale = toGrayscale(gColor);
  vec4 colorizedOutput = colorize(grayscale, gOverlay);
  FragColor = colorizedOutput;
}