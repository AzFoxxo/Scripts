///scr_tile(object_to_tile);

/***************************************************
  Basic tiling script - taken from a previous game
  This script changes the image index of an object based on its surrounding objects
  Repo: https://github.com/KnotMasterAz/Useful-Scripts
 ***************************************************/

// Top row
if (!place_meeting(x, y - 1, object_to_tile)) {
  if (!place_meeting(x - 1, y, object_to_tile)) {
    image_index = 0;
  } else if (place_meeting(x + 1, y, object_to_tile) && place_meeting(x - 1, y, object_to_tile)) {
    image_index = 1;
  } else {
    image_index = 2;
  }
}

// Middle row
else if (place_meeting(x, y - 1, object_to_tile) && place_meeting(x, y + 1, object_to_tile)) {
  if (!place_meeting(x - 1, y, object_to_tile)) {
    image_index = 3;
  } else if (place_meeting(x + 1, y, object_to_tile) && place_meeting(x - 1, y, object_to_tile)) {
    image_index = 4;
  } else {
    image_index = 5;
  }
}

// Buttom row
else {
  if (!place_meeting(x - 1, y, object_to_tile)) {
    image_index = 6;
  } else if (place_meeting(x + 1, y, object_to_tile) && place_meeting(x - 1, y, object_to_tile)) {
    image_index = 7;
  } else {
    image_index = 8;
  }
}
