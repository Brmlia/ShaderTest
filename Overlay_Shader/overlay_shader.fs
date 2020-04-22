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

vec4 applyColorize(in vec4 color, in vec4 overlay) {
  vec4 grayscale = toGrayscale(color);
  vec4 colorizedOutput = colorize(grayscale, overlay);
  return colorizedOutput;
}

vec4 applyOverlay(in vec4 color, in vec4 overlay) {
  return (vec4(mix(color.rgb, overlay.rgb, overlay.a), color.a));
}

vec4 defaultColor(in vec4 color) {
  return color;
}

void main() {
  // FragColor = defaultColor(gColor);
  // FragColor = applyColorize(gColor, gOverlay);
  FragColor = applyOverlay(gColor, gOverlay);
}