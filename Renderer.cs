using ClickableTransparentOverlay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;


namespace OneArmedCookCheat
{
    public class Renderer : Overlay
    {
        public float IntFOV;
        public int currentMoney;
        protected override void Render()
        {
            ImGui.Begin("OAC Trainer");
            if (ImGui.BeginTabBar("CheatMenu"))
            {
                if (ImGui.BeginTabItem("General"))
                {
                    ImGui.InputFloat("FOV", ref IntFOV);
                    ImGui.InputInt("Current Money", ref currentMoney);
                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Movement"))
                {

                    ImGui.EndTabItem();
                }

                if (ImGui.BeginTabItem("Misc"))
                {
                    ImGui.EndTabItem();
                }

                ImGui.EndTabBar();
            }
        }
    }
}
