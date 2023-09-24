using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.UI.Controls;
using Stride.UI;
namespace Godot_4_1_VS_Stride_4_1
{
  

    public class Spwaner : SyncScript
    {
     
    
    private TextBlock text;
        int cubes;
        public Entity EntityToClone;
          
 public Entity Pos;
        private Entity clonedEntity1;
        private Entity clonedEntity2;
        private float timer = 0;

        private float currentTimer = 0.1f;
        private float existTime = 4;
        private float goneTime = 2;

        private bool entitiesExist = false;

        public override void Start()
        {
            CloneEntityAndAddToScene();
            CloneEntityAndAddAsChild();
            entitiesExist = true;
            cubes=0;
            var page=Entity.Get<UIComponent>().Page;
           text= page.RootElement.FindVisualChildOfType<TextBlock>("myText");
             
            
        }

        /// This method clones an entity, adds it as a child of the current entity
        private void CloneEntityAndAddAsChild()
        {
            clonedEntity1 = EntityToClone.Clone();
            clonedEntity1.Transform.Position =Pos.Transform.Position;
            Entity.AddChild(clonedEntity1);
        }

        /// This method clones an entity, adds it to the scene root
        private void CloneEntityAndAddToScene()
        {
            
        }

        public override void Update()
        {
          
          timer += (float)Game.UpdateTime.Elapsed.Milliseconds;
            if (timer > currentTimer)
            {
                currentTimer+=0.05f;
                clonedEntity2 = EntityToClone.Clone();
            clonedEntity2.Transform.Position  = Pos.Transform.Position;
            Entity.Scene.Entities.Add(clonedEntity2);
          
            cubes++;
            text.Text="Cubes: "+ cubes.ToString();
           
           }

         
             
             // Reset timer
               
                timer = 0;
                Console.WriteLine(timer);
 
        }
    }
}