using OneArmedCookCheat;
using Swed64;

Swed swed = new Swed("OAC-Win64-Shipping");
Renderer renderer = new Renderer();
Thread renderThread = new Thread(() => renderer.Start().Wait());
renderThread.Start();

IntPtr gameBase = swed.GetModuleBase("OAC-Win64-Shipping.exe");

// Pointers
IntPtr FOVPointer = swed.ReadPointer(gameBase, 0x04C37FA0, 0x0, 0x20, 0x520) + 0x1F8;
IntPtr MoneyPointer = swed.ReadPointer(gameBase, 0x04C444F0, 0x30, 0x98, 0xDF8) + 0x238;

renderer.IntFOV = swed.ReadFloat(FOVPointer);
renderer.currentMoney = swed.ReadInt(MoneyPointer);

while (true) {
    swed.WriteFloat(FOVPointer, renderer.IntFOV);
    swed.WriteInt(MoneyPointer, renderer.currentMoney);
    Thread.Sleep(16);
}