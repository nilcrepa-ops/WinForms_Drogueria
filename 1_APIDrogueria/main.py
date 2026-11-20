from fastapi import FastAPI
from connections import router

app = FastAPI(title='API Drogueria de nicho', version='1.0')

app.include_router(router)