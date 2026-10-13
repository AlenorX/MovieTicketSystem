import yaml

class YAML():
    def __init__(self):
        pass

    def deserialize(self, path: str) -> dict:
        with open(path, 'r+') as file:
            return yaml.safe_load(file)
