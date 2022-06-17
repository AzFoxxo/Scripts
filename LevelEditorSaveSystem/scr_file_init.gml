///scr_file_init();

/***************************************************
  Basic Level editor save system - taken from a previous game
  This script is responsible for initialising the save manager
  level_file should be given a value for the level to save and load it
  Repo: https://github.com/KnotMasterAz/Useful-Scripts
 ***************************************************/

// Save system
level_data_file = "level-" + string(global.level_file) + ".ini";
level_data_count = 0;
