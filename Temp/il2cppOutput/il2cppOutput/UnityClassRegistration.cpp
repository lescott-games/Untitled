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
class PolygonCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>();
class GUIElement; 
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>();
class Halo; 
class HaloLayer; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
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
class CapsuleCollider; template <> void RegisterClass<CapsuleCollider>();
class CharacterController; 
class MeshCollider; template <> void RegisterClass<MeshCollider>();
class SphereCollider; template <> void RegisterClass<SphereCollider>();
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
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
class TrailRenderer; template <> void RegisterClass<TrailRenderer>();
class Rigidbody; 
class Rigidbody2D; 
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
class StyleSheetImporter; 
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
class Motion; 
class AnimationClip; 
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>();
class RuntimeAnimatorController; 
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

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 77 non stripped classes
	//0. Behaviour
	RegisterClass<Behaviour>();
	//1. Unity::Component
	RegisterClass<Unity::Component>();
	//2. EditorExtension
	RegisterClass<EditorExtension>();
	//3. Camera
	RegisterClass<Camera>();
	//4. GameObject
	RegisterClass<GameObject>();
	//5. Renderer
	RegisterClass<Renderer>();
	//6. GUILayer
	RegisterClass<GUILayer>();
	//7. Light
	RegisterClass<Light>();
	//8. Mesh
	RegisterClass<Mesh>();
	//9. NamedObject
	RegisterClass<NamedObject>();
	//10. MonoBehaviour
	RegisterClass<MonoBehaviour>();
	//11. Shader
	RegisterClass<Shader>();
	//12. Material
	RegisterClass<Material>();
	//13. Sprite
	RegisterClass<Sprite>();
	//14. SpriteRenderer
	RegisterClass<SpriteRenderer>();
	//15. Texture
	RegisterClass<Texture>();
	//16. Texture2D
	RegisterClass<Texture2D>();
	//17. RenderTexture
	RegisterClass<RenderTexture>();
	//18. Transform
	RegisterClass<Transform>();
	//19. UI::RectTransform
	RegisterClass<UI::RectTransform>();
	//20. Collider
	RegisterClass<Collider>();
	//21. BoxCollider
	RegisterClass<BoxCollider>();
	//22. SphereCollider
	RegisterClass<SphereCollider>();
	//23. MeshCollider
	RegisterClass<MeshCollider>();
	//24. CapsuleCollider
	RegisterClass<CapsuleCollider>();
	//25. AudioClip
	RegisterClass<AudioClip>();
	//26. SampleClip
	RegisterClass<SampleClip>();
	//27. AudioSource
	RegisterClass<AudioSource>();
	//28. AudioBehaviour
	RegisterClass<AudioBehaviour>();
	//29. Animator
	RegisterClass<Animator>();
	//30. TextRendering::Font
	RegisterClass<TextRendering::Font>();
	//31. UI::Canvas
	RegisterClass<UI::Canvas>();
	//32. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>();
	//33. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>();
	//34. Collider2D
	RegisterClass<Collider2D>();
	//35. PreloadData
	RegisterClass<PreloadData>();
	//36. Cubemap
	RegisterClass<Cubemap>();
	//37. Texture3D
	RegisterClass<Texture3D>();
	//38. Texture2DArray
	RegisterClass<Texture2DArray>();
	//39. MeshFilter
	RegisterClass<MeshFilter>();
	//40. MeshRenderer
	RegisterClass<MeshRenderer>();
	//41. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>();
	//42. MonoScript
	RegisterClass<MonoScript>();
	//43. TextAsset
	RegisterClass<TextAsset>();
	//44. NetworkManager
	RegisterClass<NetworkManager>();
	//45. GlobalGameManager
	RegisterClass<GlobalGameManager>();
	//46. GameManager
	RegisterClass<GameManager>();
	//47. AudioManager
	RegisterClass<AudioManager>();
	//48. PhysicsManager
	RegisterClass<PhysicsManager>();
	//49. PlayerSettings
	RegisterClass<PlayerSettings>();
	//50. BuildSettings
	RegisterClass<BuildSettings>();
	//51. InputManager
	RegisterClass<InputManager>();
	//52. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>();
	//53. TimeManager
	RegisterClass<TimeManager>();
	//54. TagManager
	RegisterClass<TagManager>();
	//55. GraphicsSettings
	RegisterClass<GraphicsSettings>();
	//56. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>();
	//57. DelayedCallManager
	RegisterClass<DelayedCallManager>();
	//58. QualitySettings
	RegisterClass<QualitySettings>();
	//59. ResourceManager
	RegisterClass<ResourceManager>();
	//60. MonoManager
	RegisterClass<MonoManager>();
	//61. MasterServerInterface
	RegisterClass<MasterServerInterface>();
	//62. PerformanceReportingManager
	RegisterClass<PerformanceReportingManager>();
	//63. Physics2DSettings
	RegisterClass<Physics2DSettings>();
	//64. ScriptMapper
	RegisterClass<ScriptMapper>();
	//65. UnityAnalyticsManager
	RegisterClass<UnityAnalyticsManager>();
	//66. UnityConnectSettings
	RegisterClass<UnityConnectSettings>();
	//67. RenderSettings
	RegisterClass<RenderSettings>();
	//68. LevelGameManager
	RegisterClass<LevelGameManager>();
	//69. ParticleSystemRenderer
	RegisterClass<ParticleSystemRenderer>();
	//70. TrailRenderer
	RegisterClass<TrailRenderer>();
	//71. BoxCollider2D
	RegisterClass<BoxCollider2D>();
	//72. LightmapSettings
	RegisterClass<LightmapSettings>();
	//73. ParticleSystem
	RegisterClass<ParticleSystem>();
	//74. AudioListener
	RegisterClass<AudioListener>();
	//75. FlareLayer
	RegisterClass<FlareLayer>();
	//76. CircleCollider2D
	RegisterClass<CircleCollider2D>();

}
