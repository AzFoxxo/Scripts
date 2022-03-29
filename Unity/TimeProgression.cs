using UnityEngine;

public class TimeProgression : MonoBehaviour
{
    private float _sec, _min, _hour, _day, week, month, year = 0f;

    private float _gameSpeed = 60f; // Speed of simulation

    // Update is called once per frame
    private void Update () {
        // Increment time
        _sec += Time.deltaTime * _gameSpeed;
        
        // Minute past
        if (_sec >= 60) {
            _min++;
            _sec = 0;
        }
        
        // Hour past
        if (_min >= 60) {
            _hour++;
            _min = 0;
        }
        
        // Day past
        if (_hour >= 24) {
            _day++;
            _hour = 0;
        }

        // Week past
        if (_day >= 7) {
            week++;
            _day = 0;
        }

        // Month past
        if (_week >= 4) {
            month++;
            _week = 0;
        }

        // Year past
        if (_month >= 13) {
            year++;
            _month = 0;
        }
    }
}