import "dotenv/config";

function required(name: string): string {
  const value = process.env[name];
  if (!value) {
    console.error(`Missing required environment variable: ${name}`);
    process.exit(1);
  }
  return value;
}

export const env = {
  PORT: Number(process.env.PORT) || 5000,
  MONGO_URI: required("MONGO_URI"),
};
