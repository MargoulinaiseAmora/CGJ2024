extends Node2D
class_name Game

export var playerPath : NodePath
onready var player = get_node(playerPath)

export(Array, NodePath) var levelPaths := []
onready var levels: Array = loadNodes(levelPaths)

export var currentLevelIndex = 0

func loadNodes(nodePaths: Array) -> Array:
	var nodes := []
	for nodePath in nodePaths:
		var node := get_node(nodePath)
		if node != null:
			nodes.append(node)
	return nodes

func getCurrentLevel() -> GenericLevel:
	return levels[currentLevelIndex]

func deactivateLevel(level: GenericLevel):
	level.position = Vector2(-5000, -5000)

func activateLevel(level: GenericLevel):
	level.position = Vector2(0, 0)

func resetLevel():
	
	player.position = getCurrentLevel().getStartPos()
	$Camera2D.position.x = 1024 * currentLevelIndex

func nextLevel():
	currentLevelIndex = (currentLevelIndex + 1) % levels.size()
	resetLevel()

func prevLevel():
	currentLevelIndex = (currentLevelIndex + 1) % levels.size()
	resetLevel()

# Called when the node enters the scene tree for the first time.
func _ready():
	
	var indent = 0
	
	for level in levels:
		level.position.x = indent
		indent += 1024
	
	resetLevel()

func _process(delta):
	if (Input.is_action_pressed("ui_cancel")):
		resetLevel()

func _on_Levels_end_touched():
	nextLevel()
