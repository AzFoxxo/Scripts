///scr_file_save_object(object);

/***************************************************
  Basic Level editor save system - taken from a previous game
  This script is responsible for saving a single object to the ini file storing it's x and y
  Repo: https://github.com/KnotMasterAz/Useful-Scripts
 ***************************************************/

_file_object = argument0;

with (_file_object) {
    
    ini_write_real("o", "x" + string(obj_editor.level_data_count), x);
    ini_write_real("o", "y" + string(obj_editor.level_data_count), y);
    ini_write_string("o", "n" + string(obj_editor.level_data_count), object_get_name(obj_editor._file_object));
    obj_editor.level_data_count++;
}
