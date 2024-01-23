extends StaticBody2D

class_name Door

signal player_activated_button
signal player_left_button


func open():
	$CollisionShape2D.set_deferred("disabled",true)
	get_node("closed").visible = false
	get_node("opened").visible = true


func close():
	$CollisionShape2D.set_deferred("disabled",false)
	get_node("closed").visible = true
	get_node("opened").visible = false
