import mongoose from "mongoose";
import app from "./app.js";
import { env } from "./config/env.js";

try {
  await mongoose.connect(env.MONGO_URI);
  console.log("MongoDB connected");

  app.listen(env.PORT, () => {
    console.log(`Server running on port ${env.PORT}`);
  });
} catch (err) {
  const message = err instanceof Error ? err.message : String(err);
  console.error("MongoDB connection failed:", message);
  process.exit(1);
}
