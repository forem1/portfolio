package com.example.alarmservice

import android.content.BroadcastReceiver
import android.content.Context
import android.content.Intent
import android.widget.Toast

class MyAlarmReciever : BroadcastReceiver() {
    override fun onReceive(p0: Context?, p1: Intent?) {
        Toast.makeText(p0!!, "Динь-дон", Toast.LENGTH_LONG).show()
    }
}