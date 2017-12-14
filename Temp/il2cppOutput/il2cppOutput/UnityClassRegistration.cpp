template <typename T> void RegisterClass();
template <typename T> void RegisterStrippedTypeInfo(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_PerformanceReporting();
	RegisterModule_PerformanceReporting();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_GameCenter();
	RegisterModule_GameCenter();

	void RegisterModule_Wind();
	RegisterModule_Wind();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_ImageConversion();
	RegisterModule_ImageConversion();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>();
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>();
class Behaviour; template <> void RegisterClass<Behaviour>();
class Animation; 
class Animator; template <> void RegisterClass<Animator>();
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>();
class AudioListener; template <> void RegisterClass<AudioListener>();
class AudioSource; template <> void RegisterClass<AudioSource>();
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>();
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>();
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>();
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterClass<Collider2D>();
class BoxCollider2D; template <> void RegisterClass<BoxCollider2D>();
class CapsuleCollider2D; 
class CircleCollider2D; template <> void RegisterClass<CircleCollider2D>();
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; template <> void RegisterClass<PolygonCollider2D>();
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>();
class GUIElement; template <> void RegisterClass<GUIElement>();
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>();
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class Joint2D; template <> void RegisterClass<Joint2D>();
class AnchoredJoint2D; template <> void RegisterClass<AnchoredJoint2D>();
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; template <> void RegisterClass<HingeJoint2D>();
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterClass<Light>();
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>();
class NavMeshAgent; 
class NavMeshObstacle; 
class NetworkView; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>();
class Collider; template <> void RegisterClass<Collider>();
class BoxCollider; template <> void RegisterClass<BoxCollider>();
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; template <> void RegisterClass<MeshCollider>();
class SphereCollider; template <> void RegisterClass<SphereCollider>();
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } template <> void RegisterClass<Unity::Joint>();
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } template <> void RegisterClass<Unity::HingeJoint>();
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>();
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; template <> void RegisterClass<ParticleSystem>();
class Renderer; template <> void RegisterClass<Renderer>();
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>();
class ParticleRenderer; 
class ParticleSystemRenderer; template <> void RegisterClass<ParticleSystemRenderer>();
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterClass<SpriteRenderer>();
class TilemapRenderer; 
class TrailRenderer; template <> void RegisterClass<TrailRenderer>();
class Rigidbody; template <> void RegisterClass<Rigidbody>();
class Rigidbody2D; template <> void RegisterClass<Rigidbody2D>();
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterClass<Transform>();
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>();
class Tree; 
class WorldAnchor; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>();
class NamedObject; template <> void RegisterClass<NamedObject>();
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>();
class GameObjectRecorder; 
class LightProbes; 
class Material; template <> void RegisterClass<Material>();
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>();
class Motion; template <> void RegisterClass<Motion>();
class AnimationClip; template <> void RegisterClass<AnimationClip>();
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>();
class RuntimeAnimatorController; template <> void RegisterClass<RuntimeAnimatorController>();
class AnimatorController; 
class AnimatorOverrideController; 
class SampleClip; template <> void RegisterClass<SampleClip>();
class AudioClip; template <> void RegisterClass<AudioClip>();
class Shader; template <> void RegisterClass<Shader>();
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>();
class SpriteAtlas; 
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>();
class CGProgram; 
class MonoScript; template <> void RegisterClass<MonoScript>();
class Texture; template <> void RegisterClass<Texture>();
class BaseVideoTexture; 
class MovieTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>();
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>();
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>();
class Cubemap; template <> void RegisterClass<Cubemap>();
class Texture2DArray; template <> void RegisterClass<Texture2DArray>();
class Texture3D; template <> void RegisterClass<Texture3D>();
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>();
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>();
class AudioManager; template <> void RegisterClass<AudioManager>();
class BuildSettings; template <> void RegisterClass<BuildSettings>();
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>();
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>();
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>();
class InputManager; template <> void RegisterClass<InputManager>();
class MasterServerInterface; template <> void RegisterClass<MasterServerInterface>();
class MonoManager; template <> void RegisterClass<MonoManager>();
class NavMeshProjectSettings; 
class NetworkManager; template <> void RegisterClass<NetworkManager>();
class PerformanceReportingManager; template <> void RegisterClass<PerformanceReportingManager>();
class Physics2DSettings; template <> void RegisterClass<Physics2DSettings>();
class PhysicsManager; template <> void RegisterClass<PhysicsManager>();
class PlayerSettings; template <> void RegisterClass<PlayerSettings>();
class QualitySettings; template <> void RegisterClass<QualitySettings>();
class ResourceManager; template <> void RegisterClass<ResourceManager>();
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>();
class ScriptMapper; template <> void RegisterClass<ScriptMapper>();
class TagManager; template <> void RegisterClass<TagManager>();
class TimeManager; template <> void RegisterClass<TimeManager>();
class UnityAnalyticsManager; template <> void RegisterClass<UnityAnalyticsManager>();
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>();
class LevelGameManager; template <> void RegisterClass<LevelGameManager>();
class LightmapSettings; template <> void RegisterClass<LightmapSettings>();
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>();
class NScreenBridge; 
class RenderPassAttachment; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 88 non stripped classes
	//0. Rigidbody
	RegisterClass<Rigidbody>();
	//1. Unity::Component
	RegisterClass<Unity::Component>();
	//2. EditorExtension
	RegisterClass<EditorExtension>();
	//3. Unity::Joint
	RegisterClass<Unity::Joint>();
	//4. Unity::HingeJoint
	RegisterClass<Unity::HingeJoint>();
	//5. BoxCollider
	RegisterClass<BoxCollider>();
	//6. Collider
	RegisterClass<Collider>();
	//7. SphereCollider
	RegisterClass<SphereCollider>();
	//8. Behaviour
	RegisterClass<Behaviour>();
	//9. Camera
	RegisterClass<Camera>();
	//10. GameObject
	RegisterClass<GameObject>();
	//11. MeshFilter
	RegisterClass<MeshFilter>();
	//12. Renderer
	RegisterClass<Renderer>();
	//13. GUIElement
	RegisterClass<GUIElement>();
	//14. GUILayer
	RegisterClass<GUILayer>();
	//15. Light
	RegisterClass<Light>();
	//16. Mesh
	RegisterClass<Mesh>();
	//17. NamedObject
	RegisterClass<NamedObject>();
	//18. MonoBehaviour
	RegisterClass<MonoBehaviour>();
	//19. Shader
	RegisterClass<Shader>();
	//20. Material
	RegisterClass<Material>();
	//21. Sprite
	RegisterClass<Sprite>();
	//22. SpriteRenderer
	RegisterClass<SpriteRenderer>();
	//23. TextAsset
	RegisterClass<TextAsset>();
	//24. Texture
	RegisterClass<Texture>();
	//25. Texture2D
	RegisterClass<Texture2D>();
	//26. RenderTexture
	RegisterClass<RenderTexture>();
	//27. Transform
	RegisterClass<Transform>();
	//28. UI::RectTransform
	RegisterClass<UI::RectTransform>();
	//29. AnimationClip
	RegisterClass<AnimationClip>();
	//30. Motion
	RegisterClass<Motion>();
	//31. Animator
	RegisterClass<Animator>();
	//32. TextRendering::Font
	RegisterClass<TextRendering::Font>();
	//33. UI::Canvas
	RegisterClass<UI::Canvas>();
	//34. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>();
	//35. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>();
	//36. AudioClip
	RegisterClass<AudioClip>();
	//37. SampleClip
	RegisterClass<SampleClip>();
	//38. AudioListener
	RegisterClass<AudioListener>();
	//39. AudioBehaviour
	RegisterClass<AudioBehaviour>();
	//40. AudioSource
	RegisterClass<AudioSource>();
	//41. Rigidbody2D
	RegisterClass<Rigidbody2D>();
	//42. Collider2D
	RegisterClass<Collider2D>();
	//43. CircleCollider2D
	RegisterClass<CircleCollider2D>();
	//44. BoxCollider2D
	RegisterClass<BoxCollider2D>();
	//45. PolygonCollider2D
	RegisterClass<PolygonCollider2D>();
	//46. Joint2D
	RegisterClass<Joint2D>();
	//47. AnchoredJoint2D
	RegisterClass<AnchoredJoint2D>();
	//48. HingeJoint2D
	RegisterClass<HingeJoint2D>();
	//49. MeshRenderer
	RegisterClass<MeshRenderer>();
	//50. RuntimeAnimatorController
	RegisterClass<RuntimeAnimatorController>();
	//51. PreloadData
	RegisterClass<PreloadData>();
	//52. Cubemap
	RegisterClass<Cubemap>();
	//53. Texture3D
	RegisterClass<Texture3D>();
	//54. Texture2DArray
	RegisterClass<Texture2DArray>();
	//55. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>();
	//56. GraphicsSettings
	RegisterClass<GraphicsSettings>();
	//57. GlobalGameManager
	RegisterClass<GlobalGameManager>();
	//58. GameManager
	RegisterClass<GameManager>();
	//59. InputManager
	RegisterClass<InputManager>();
	//60. PlayerSettings
	RegisterClass<PlayerSettings>();
	//61. ResourceManager
	RegisterClass<ResourceManager>();
	//62. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>();
	//63. TimeManager
	RegisterClass<TimeManager>();
	//64. TagManager
	RegisterClass<TagManager>();
	//65. DelayedCallManager
	RegisterClass<DelayedCallManager>();
	//66. QualitySettings
	RegisterClass<QualitySettings>();
	//67. BuildSettings
	RegisterClass<BuildSettings>();
	//68. MasterServerInterface
	RegisterClass<MasterServerInterface>();
	//69. NetworkManager
	RegisterClass<NetworkManager>();
	//70. ScriptMapper
	RegisterClass<ScriptMapper>();
	//71. PhysicsManager
	RegisterClass<PhysicsManager>();
	//72. MonoScript
	RegisterClass<MonoScript>();
	//73. MonoManager
	RegisterClass<MonoManager>();
	//74. UnityAnalyticsManager
	RegisterClass<UnityAnalyticsManager>();
	//75. PerformanceReportingManager
	RegisterClass<PerformanceReportingManager>();
	//76. UnityConnectSettings
	RegisterClass<UnityConnectSettings>();
	//77. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>();
	//78. AudioManager
	RegisterClass<AudioManager>();
	//79. Physics2DSettings
	RegisterClass<Physics2DSettings>();
	//80. LevelGameManager
	RegisterClass<LevelGameManager>();
	//81. FlareLayer
	RegisterClass<FlareLayer>();
	//82. RenderSettings
	RegisterClass<RenderSettings>();
	//83. MeshCollider
	RegisterClass<MeshCollider>();
	//84. TrailRenderer
	RegisterClass<TrailRenderer>();
	//85. LightmapSettings
	RegisterClass<LightmapSettings>();
	//86. ParticleSystem
	RegisterClass<ParticleSystem>();
	//87. ParticleSystemRenderer
	RegisterClass<ParticleSystemRenderer>();

}
