import jwt
import uuid
import winreg
import pyperclip
from os import system
REG_PATH = 'SOFTWARE\\Bolcorp'

def set_reg(name, value):
    winreg.CreateKey(winreg.HKEY_CURRENT_USER, REG_PATH)
    registry_key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, REG_PATH, 0, winreg.KEY_WRITE)
    winreg.SetValueEx(registry_key, name, 0, winreg.REG_SZ, value)
    winreg.CloseKey(registry_key)
    return True

def get_reg(name):
    registry_key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, REG_PATH, 0, winreg.KEY_READ)
    (value, regtype) = winreg.QueryValueEx(registry_key, name)
    winreg.CloseKey(registry_key)
    return value

secret = '!FuF5&ZC#YnG#SS9jCbV8F'
regUUID = get_reg('glid')
newUUID = uuid.uuid4()
outUUID = None
if regUUID:
    outUUID = regUUID
else:
    outUUID = newUUID
    set_reg('glid', str(outUUID))
encoded_jwt = jwt.encode({'glid': str(outUUID) }, secret, algorithm = 'HS256')
system('color 0a')
system('title Bolmax Validator 1.0')
print('\n\n\n')
print('\tBolmax Validator 1.0\n')
print('\t> Token kodunuz panoya kopyalandı.\n')
pyperclip.copy(encoded_jwt)
print('\tProgramı kapatmak için entera basın..')
input()