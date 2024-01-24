extends Node2D
class_name Game

onready var levels: Array = $Levels.get_children()

export var currentLevelIndex = 0

<<<<<<< Updated upstream
func loadNodes(nodePaths: Array) -> Array:
	var nodes := []
	for nodePath in nodePaths:
		var node := get_node(nodePath)
		if node != null:
			nodes.append(node)
	return nodes

=======
>>>>>>> Stashed changes
func getCurrentLevel() -> GenericLevel:
	return levels[currentLevelIndex]

func resetLevel():
<<<<<<< Updated upstream
	
	player.position = getCurrentLevel().getStartPos()
	$Camera2D.position.x = 1024 * currentLevelIndex
=======
	$Player.position = getCurrentLevel().getStartPos()
	$Player.reset_position()
	$Camera2D.position.x = 1034 * currentLevelIndex
>>>>>>> Stashed changes

func nextLevel():
	print("Prochain niveauu")
	
	currentLevelIndex = (currentLevelIndex + 1) % levels.size()
	
	print($Player.position)
	
	resetLevel()

func prevLevel():
	currentLevelIndex = (currentLevelIndex + 1) % levels.size()
	resetLevel()

# Called when the node enters the scene tree for the first time.
func _ready():
	
	var indent = 0
<<<<<<< Updated upstream
	
	for level in levels:
		level.position.x = indent
		indent += 1024
=======
	for level in levels:
		level.position.x += indent
		indent += 1034
>>>>>>> Stashed changes
	
	resetLevel()

func _process(delta):
	if (Input.is_action_pressed("ui_cancel")):
		resetLevel()



func _on_Levels_end_touched():
	nextLevel()
