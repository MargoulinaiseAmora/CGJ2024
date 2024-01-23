extends KinematicBody2D

export var speed = 500
export var acceleration = 0.1
export var deceleration = 0.04
export var velocity = Vector2()

func get_input():
	var target_velocity = Vector2()
	if Input.is_action_pressed('ui_right'):
		target_velocity.x += 1
	if Input.is_action_pressed('ui_left'):
		target_velocity.x -= 1
	if Input.is_action_pressed('ui_down'):
		target_velocity.y += 1
	if Input.is_action_pressed('ui_up'):
		target_velocity.y -= 1
	target_velocity = target_velocity.normalized() * speed
	
	if target_velocity == Vector2.ZERO:
		velocity = velocity.linear_interpolate(Vector2.ZERO, deceleration)
	else:
		velocity = velocity.linear_interpolate(target_velocity, acceleration)

func _physics_process(delta):
	if get_parent().meditating:
		get_input()
		move_and_collide(velocity * delta)
