import "dotenv/config";
import express from "express";
import mongoose from "mongoose";

const app = express();
const PORT = Number(process.env.PORT) || 5000;
const MONGO_URI = process.env.MONGO_URI;

if (!MONGO_URI) {
  console.error("MONGO_URI is missing. Add it to server/.env");
  process.exit(1);
}

try {
  await mongoose.connect(MONGO_URI);
  console.log("MongoDB connected");

  app.listen(PORT, () => {
    console.log(`Server running on port ${PORT}`);
  });
} catch (err) {
  const message = err instanceof Error ? err.message : String(err);
  console.error("MongoDB connection failed:", message);
  process.exit(1);
}
